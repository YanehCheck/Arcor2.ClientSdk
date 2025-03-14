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
    /// Data(message: str, type: str, handled: bool &#x3D; False)
    /// </summary>
    [DataContract(Name = "ProjectExceptionData")]
    public partial class ProjectExceptionData : IEquatable<ProjectExceptionData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExceptionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectExceptionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExceptionData" /> class.
        /// </summary>
        /// <param name="message">message (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="handled">handled (default to false).</param>
        public ProjectExceptionData(string message = default(string), string type = default(string), bool handled = false)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for ProjectExceptionData and cannot be null");
            }
            this.Message = message;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ProjectExceptionData and cannot be null");
            }
            this.Type = type;
            this.Handled = handled;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Handled
        /// </summary>
        [DataMember(Name = "handled", EmitDefaultValue = true)]
        public bool Handled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectExceptionData {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Handled: ").Append(Handled).Append("\n");
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
            return this.Equals(input as ProjectExceptionData);
        }

        /// <summary>
        /// Returns true if ProjectExceptionData instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectExceptionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectExceptionData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Handled == input.Handled ||
                    this.Handled.Equals(input.Handled)
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
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Handled.GetHashCode();
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
