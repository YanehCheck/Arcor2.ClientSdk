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
    /// Args(source_id: str, target_name: str)
    /// </summary>
    [DataContract(Name = "CopySceneRequestArgs")]
    public partial class CopySceneRequestArgs : IEquatable<CopySceneRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopySceneRequestArgs" /> class.
        /// </summary>
        [JsonConstructor]
        protected CopySceneRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopySceneRequestArgs" /> class.
        /// </summary>
        /// <param name="sourceId">sourceId (required).</param>
        /// <param name="targetName">targetName (required).</param>
        public CopySceneRequestArgs(string sourceId = default, string targetName = default)
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for CopySceneRequestArgs and cannot be null");
            }
            SourceId = sourceId;
            // to ensure "targetName" is required (not null)
            if (targetName == null)
            {
                throw new ArgumentNullException("targetName is a required property for CopySceneRequestArgs and cannot be null");
            }
            TargetName = targetName;
        }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "source_id", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets TargetName
        /// </summary>
        [DataMember(Name = "target_name", IsRequired = true, EmitDefaultValue = true)]
        public string TargetName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CopySceneRequestArgs {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
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
            return Equals(input as CopySceneRequestArgs);
        }

        /// <summary>
        /// Returns true if CopySceneRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of CopySceneRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopySceneRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    SourceId == input.SourceId ||
                    (SourceId != null &&
                    SourceId.Equals(input.SourceId))
                ) && 
                (
                    TargetName == input.TargetName ||
                    (TargetName != null &&
                    TargetName.Equals(input.TargetName))
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
                if (SourceId != null)
                {
                    hashCode = hashCode * 59 + SourceId.GetHashCode();
                }
                if (TargetName != null)
                {
                    hashCode = hashCode * 59 + TargetName.GetHashCode();
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
