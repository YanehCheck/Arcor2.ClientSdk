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

namespace Arcor2.ClientSdk.Communication.OpenApi.Models
{
    /// <summary>
    /// Args(object_id: str)
    /// </summary>
    [DataContract(Name = "WriteUnlockRequestArgs")]
    public partial class WriteUnlockRequestArgs : IEquatable<WriteUnlockRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteUnlockRequestArgs" /> class.
        /// </summary>
        [JsonConstructor]
        protected WriteUnlockRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteUnlockRequestArgs" /> class.
        /// </summary>
        /// <param name="objectId">objectId (required).</param>
        public WriteUnlockRequestArgs(string objectId = default)
        {
            // to ensure "objectId" is required (not null)
            if (objectId == null)
            {
                throw new ArgumentNullException("objectId is a required property for WriteUnlockRequestArgs and cannot be null");
            }
            ObjectId = objectId;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "object_id", IsRequired = true, EmitDefaultValue = true)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WriteUnlockRequestArgs {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return Equals(input as WriteUnlockRequestArgs);
        }

        /// <summary>
        /// Returns true if WriteUnlockRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteUnlockRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteUnlockRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                ObjectId == input.ObjectId ||
                (ObjectId != null &&
                 ObjectId.Equals(input.ObjectId));
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
                if (ObjectId != null)
                {
                    hashCode = hashCode * 59 + ObjectId.GetHashCode();
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
