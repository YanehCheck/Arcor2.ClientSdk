/*
 * ARCOR2 ARServer Data Models
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Arcor2.ClientSdk.Communication.OpenApi.Models
{
    /// <summary>
    /// PackageChanged(data: arcor2_execution_data.common.PackageSummary)
    /// </summary>
    [DataContract(Name = "PackageChanged")]
    public partial class PackageChanged : IEquatable<PackageChanged>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="PackageChanged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageChanged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageChanged" /> class.
        /// </summary>
        /// <param name="varEvent">varEvent (required).</param>
        /// <param name="changeType">changeType.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="data">data (required).</param>
        public PackageChanged(string varEvent = default(string), ChangeTypeEnum? changeType = default(ChangeTypeEnum?), string parentId = default(string), PackageSummary data = default(PackageSummary))
        {
            // to ensure "varEvent" is required (not null)
            if (varEvent == null)
            {
                throw new ArgumentNullException("varEvent is a required property for PackageChanged and cannot be null");
            }
            this.Event = varEvent;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for PackageChanged and cannot be null");
            }
            this.Data = data;
            this.ChangeType = changeType;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = true)]
        public string Event { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public PackageSummary Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PackageChanged {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageChanged);
        }

        /// <summary>
        /// Returns true if PackageChanged instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageChanged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageChanged input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.ChangeType == input.ChangeType ||
                    this.ChangeType.Equals(input.ChangeType)
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Event != null)
                {
                    hashCode = (hashCode * 59) + this.Event.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChangeType.GetHashCode();
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
