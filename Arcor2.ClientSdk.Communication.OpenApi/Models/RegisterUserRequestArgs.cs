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
    /// Args(user_name: str)
    /// </summary>
    [DataContract(Name = "RegisterUserRequestArgs")]
    public partial class RegisterUserRequestArgs : IEquatable<RegisterUserRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterUserRequestArgs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterUserRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterUserRequestArgs" /> class.
        /// </summary>
        /// <param name="userName">userName (required).</param>
        public RegisterUserRequestArgs(string userName = default(string))
        {
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new ArgumentNullException("userName is a required property for RegisterUserRequestArgs and cannot be null");
            }
            this.UserName = userName;
        }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", IsRequired = true, EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterUserRequestArgs {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as RegisterUserRequestArgs);
        }

        /// <summary>
        /// Returns true if RegisterUserRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterUserRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterUserRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
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
