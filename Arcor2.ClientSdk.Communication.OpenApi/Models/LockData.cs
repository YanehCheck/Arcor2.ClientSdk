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
    /// LockData(object_ids: list[str], owner: str)
    /// </summary>
    [DataContract(Name = "LockData")]
    public partial class LockData : IEquatable<LockData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LockData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LockData" /> class.
        /// </summary>
        /// <param name="objectIds">objectIds (required).</param>
        /// <param name="owner">owner (required).</param>
        public LockData(List<string> objectIds = default(List<string>), string owner = default(string))
        {
            // to ensure "objectIds" is required (not null)
            if (objectIds == null)
            {
                throw new ArgumentNullException("objectIds is a required property for LockData and cannot be null");
            }
            this.ObjectIds = objectIds;
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new ArgumentNullException("owner is a required property for LockData and cannot be null");
            }
            this.Owner = owner;
        }

        /// <summary>
        /// Gets or Sets ObjectIds
        /// </summary>
        [DataMember(Name = "object_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ObjectIds { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LockData {\n");
            sb.Append("  ObjectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as LockData);
        }

        /// <summary>
        /// Returns true if LockData instances are equal
        /// </summary>
        /// <param name="input">Instance of LockData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectIds == input.ObjectIds ||
                    this.ObjectIds != null &&
                    input.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(input.ObjectIds)
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.ObjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectIds.GetHashCode();
                }
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
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
