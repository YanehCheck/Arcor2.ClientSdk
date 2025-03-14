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
    /// Args(joints_id: str, new_name: str)
    /// </summary>
    [DataContract(Name = "RenameActionPointJointsRequestArgs")]
    public partial class RenameActionPointJointsRequestArgs : IEquatable<RenameActionPointJointsRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameActionPointJointsRequestArgs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RenameActionPointJointsRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameActionPointJointsRequestArgs" /> class.
        /// </summary>
        /// <param name="jointsId">jointsId (required).</param>
        /// <param name="newName">newName (required).</param>
        public RenameActionPointJointsRequestArgs(string jointsId = default(string), string newName = default(string))
        {
            // to ensure "jointsId" is required (not null)
            if (jointsId == null)
            {
                throw new ArgumentNullException("jointsId is a required property for RenameActionPointJointsRequestArgs and cannot be null");
            }
            this.JointsId = jointsId;
            // to ensure "newName" is required (not null)
            if (newName == null)
            {
                throw new ArgumentNullException("newName is a required property for RenameActionPointJointsRequestArgs and cannot be null");
            }
            this.NewName = newName;
        }

        /// <summary>
        /// Gets or Sets JointsId
        /// </summary>
        [DataMember(Name = "joints_id", IsRequired = true, EmitDefaultValue = true)]
        public string JointsId { get; set; }

        /// <summary>
        /// Gets or Sets NewName
        /// </summary>
        [DataMember(Name = "new_name", IsRequired = true, EmitDefaultValue = true)]
        public string NewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenameActionPointJointsRequestArgs {\n");
            sb.Append("  JointsId: ").Append(JointsId).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
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
            return this.Equals(input as RenameActionPointJointsRequestArgs);
        }

        /// <summary>
        /// Returns true if RenameActionPointJointsRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of RenameActionPointJointsRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenameActionPointJointsRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JointsId == input.JointsId ||
                    (this.JointsId != null &&
                    this.JointsId.Equals(input.JointsId))
                ) && 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
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
                if (this.JointsId != null)
                {
                    hashCode = (hashCode * 59) + this.JointsId.GetHashCode();
                }
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
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
