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
    /// Request(id: int)
    /// </summary>
    [DataContract(Name = "ResumePackageRequest")]
    public partial class ResumePackageRequest : IEquatable<ResumePackageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePackageRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected ResumePackageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePackageRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="request">request (required).</param>
        public ResumePackageRequest(int id = default, string request = default)
        {
            Id = id;
            // to ensure "request" is required (not null)
            if (request == null)
            {
                throw new ArgumentNullException("request is a required property for ResumePackageRequest and cannot be null");
            }
            Request = request;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", IsRequired = true, EmitDefaultValue = true)]
        public string Request { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResumePackageRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
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
            return Equals(input as ResumePackageRequest);
        }

        /// <summary>
        /// Returns true if ResumePackageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ResumePackageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResumePackageRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Id == input.Id ||
                    Id.Equals(input.Id)
                ) && 
                (
                    Request == input.Request ||
                    (Request != null &&
                    Request.Equals(input.Request))
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
                hashCode = hashCode * 59 + Id.GetHashCode();
                if (Request != null)
                {
                    hashCode = hashCode * 59 + Request.GetHashCode();
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
