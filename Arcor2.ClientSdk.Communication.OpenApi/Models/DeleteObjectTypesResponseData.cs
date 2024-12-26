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
    /// Data(id: str, error: str)
    /// </summary>
    [DataContract(Name = "DeleteObjectTypesResponseData")]
    public partial class DeleteObjectTypesResponseData : IEquatable<DeleteObjectTypesResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteObjectTypesResponseData" /> class.
        /// </summary>
        [JsonConstructor]
        protected DeleteObjectTypesResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteObjectTypesResponseData" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="error">error (required).</param>
        public DeleteObjectTypesResponseData(string id = default, string error = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DeleteObjectTypesResponseData and cannot be null");
            }
            Id = id;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for DeleteObjectTypesResponseData and cannot be null");
            }
            Error = error;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteObjectTypesResponseData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return Equals(input as DeleteObjectTypesResponseData);
        }

        /// <summary>
        /// Returns true if DeleteObjectTypesResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteObjectTypesResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteObjectTypesResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Error == input.Error ||
                    (Error != null &&
                    Error.Equals(input.Error))
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
                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }
                if (Error != null)
                {
                    hashCode = hashCode * 59 + Error.GetHashCode();
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
