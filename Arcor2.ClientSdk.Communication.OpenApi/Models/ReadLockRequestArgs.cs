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
    /// Args(object_id: str)
    /// </summary>
    [DataContract(Name = "ReadLockRequestArgs")]
    public partial class ReadLockRequestArgs : IEquatable<ReadLockRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadLockRequestArgs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReadLockRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadLockRequestArgs" /> class.
        /// </summary>
        /// <param name="objectId">objectId (required).</param>
        public ReadLockRequestArgs(string objectId = default(string))
        {
            // to ensure "objectId" is required (not null)
            if (objectId == null)
            {
                throw new ArgumentNullException("objectId is a required property for ReadLockRequestArgs and cannot be null");
            }
            this.ObjectId = objectId;
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
            sb.Append("class ReadLockRequestArgs {\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadLockRequestArgs);
        }

        /// <summary>
        /// Returns true if ReadLockRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadLockRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadLockRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.ObjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectId.GetHashCode();
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
