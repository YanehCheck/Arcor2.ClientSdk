﻿using System;
using System.Threading.Tasks;
using Arcor2.ClientSdk.Communication;
using Arcor2.ClientSdk.Communication.OpenApi.Models;

namespace Arcor2.ClientSdk.ClientServices.Models {
    /// <summary>
    /// Base class for manager classes with identity. Provides locking features.
    /// </summary>
    /// <remarks>
    /// If the object does not have distinct identity and does not need locking, use <see cref="Arcor2ObjectManager"/>.
    /// </remarks>
    public abstract class LockableArcor2ObjectManager : Arcor2ObjectManager {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Is the object write-locked?
        /// </summary>
        /// <seealso cref="LockOwner"/>
        public bool Locked { get; private set; }

        /// <summary>
        /// The owner of a write-lock on this object.
        /// </summary>
        /// <value>
        /// The owner username, <c>null</c> if unlocked.
        /// </value>
        public string? LockOwner { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LockableArcor2ObjectManager"/> class.
        /// </summary>
        /// <param name="session">The session used for communication with the server. Should generally inject only itself.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="session"/> is null.</exception>
        protected LockableArcor2ObjectManager(Arcor2Session session, string id) : base(session) {
            Id = Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Locks the resource represented by this instance.
        /// </summary>
        /// <exception cref="Arcor2Exception"></exception>
        protected internal async Task LockAsync() {
            var @lock = await Session.client.WriteLockAsync(new WriteLockRequestArgs(Id));
            if(!@lock.Result) {
                throw new Arcor2Exception($"Locking object {Id} failed.", @lock.Messages);
            }
        }

        /// <summary>
        /// Unlocks the resource represented by this instance.
        /// </summary>
        /// <exception cref="Arcor2Exception"></exception>
        protected internal async Task UnlockAsync() {
            var @lock = await Session.client.WriteUnlockAsync(new WriteUnlockRequestArgs(Id));
            if(!@lock.Result) {
                throw new Arcor2Exception($"Unlocking object {Id} failed.", @lock.Messages);
            }
        }

        /// <summary>
        /// Registers event handlers from session/client. Derived classes should override this method to register their specific handlers and invoke the base method.
        /// </summary>
        protected override void RegisterHandlers() {
            base.RegisterHandlers();
            Session.client.OnObjectsLocked += OnObjectsLocked;
            Session.client.OnObjectsUnlocked += OnObjectsUnlocked;
        }

        /// <summary>
        /// Unregisters event handlers from session/client. Derived classes should override this method to unregister their specific handlers and invoke the base method.
        /// </summary>
        protected override void UnregisterHandlers() {
            base.UnregisterHandlers();
            Session.client.OnObjectsLocked -= OnObjectsLocked;
            Session.client.OnObjectsUnlocked -= OnObjectsUnlocked;
        }

        private void OnObjectsLocked(object sender, ObjectsLockEventArgs e) {
            if (e.Data.ObjectIds.Contains(Id)) {
                if (Locked) {
                    Session.logger?.LogWarning($"The object {Id} received lock event message while already locked.");
                }
                Locked = true;
                LockOwner = e.Data.Owner;
            }
        }

        private void OnObjectsUnlocked(object sender, ObjectsLockEventArgs e) {
            if(e.Data.ObjectIds.Contains(Id)) {
                if(!Locked) {
                    Session.logger?.LogWarning($"The object {Id} received unlock event message while already unlocked.");
                }
                Locked = false;
                LockOwner = null;
            }
        }
    }
}