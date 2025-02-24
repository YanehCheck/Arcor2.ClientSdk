﻿namespace Arcor2.ClientSdk.ClientServices.Models.Extras {
    /// <summary>
    /// Represents a joint and its value.
    /// </summary>
    public class Joint {
        /// <summary>
        /// The joint ID.
        /// </summary>
        public string Id { get; private set; }
        /// <summary>
        /// The joint value.
        /// </summary>
        public decimal Value { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Joint"/> class.
        /// </summary>
        /// <param name="id">The joint ID.</param>
        /// <param name="value">The joint value.</param>
        public Joint(string id, decimal value) {
            Id = id;
            Value = value;
        }
    }
}