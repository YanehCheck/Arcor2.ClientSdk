/*
 * ARCOR2 ARServer Data Models
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Arcor2.ClientSdk.Communication.OpenApi.Models
{
    /// <summary>
    /// Event()
    /// </summary>
    [DataContract(Name = "Event")]
    public partial class Event : IEquatable<Event>, IValidatableObject
    {
        /// <summary>
        /// Defines ChangeType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChangeTypeEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 2,

            /// <summary>
            /// Enum Remove for value: remove
            /// </summary>
            [EnumMember(Value = "remove")]
            Remove = 3,

            /// <summary>
            /// Enum UpdateBase for value: update_base
            /// </summary>
            [EnumMember(Value = "update_base")]
            UpdateBase = 4
        }


        /// <summary>
        /// Gets or Sets ChangeType
        /// </summary>
        [DataMember(Name = "change_type", EmitDefaultValue = false)]
        public ChangeTypeEnum? ChangeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructor]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="varEvent">varEvent (required).</param>
        /// <param name="changeType">changeType.</param>
        /// <param name="parentId">parentId.</param>
        public Event(string varEvent = default, ChangeTypeEnum? changeType = default, string parentId = default)
        {
            // to ensure "varEvent" is required (not null)
            if (varEvent == null)
            {
                throw new ArgumentNullException("varEvent is a required property for Event and cannot be null");
            }
            VarEvent = varEvent;
            ChangeType = changeType;
            ParentId = parentId;
        }

        /// <summary>
        /// Gets or Sets VarEvent
        /// </summary>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = true)]
        public string VarEvent { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  VarEvent: ").Append(VarEvent).Append("\n");
            sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="input">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    VarEvent == input.VarEvent ||
                    (VarEvent != null &&
                    VarEvent.Equals(input.VarEvent))
                ) && 
                (
                    ChangeType == input.ChangeType ||
                    ChangeType.Equals(input.ChangeType)
                ) && 
                (
                    ParentId == input.ParentId ||
                    (ParentId != null &&
                    ParentId.Equals(input.ParentId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (VarEvent != null)
                {
                    hashCode = hashCode * 59 + VarEvent.GetHashCode();
                }
                hashCode = hashCode * 59 + ChangeType.GetHashCode();
                if (ParentId != null)
                {
                    hashCode = hashCode * 59 + ParentId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
