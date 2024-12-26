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
    /// Args(robot_id: str, arm_id: Optional[str] &#x3D; None)
    /// </summary>
    [DataContract(Name = "GetSuctionsRequestArgs")]
    public partial class GetSuctionsRequestArgs : IEquatable<GetSuctionsRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSuctionsRequestArgs" /> class.
        /// </summary>
        [JsonConstructor]
        protected GetSuctionsRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSuctionsRequestArgs" /> class.
        /// </summary>
        /// <param name="robotId">robotId (required).</param>
        /// <param name="armId">armId.</param>
        public GetSuctionsRequestArgs(string robotId = default, string armId = default)
        {
            // to ensure "robotId" is required (not null)
            if (robotId == null)
            {
                throw new ArgumentNullException("robotId is a required property for GetSuctionsRequestArgs and cannot be null");
            }
            RobotId = robotId;
            ArmId = armId;
        }

        /// <summary>
        /// Gets or Sets RobotId
        /// </summary>
        [DataMember(Name = "robot_id", IsRequired = true, EmitDefaultValue = true)]
        public string RobotId { get; set; }

        /// <summary>
        /// Gets or Sets ArmId
        /// </summary>
        [DataMember(Name = "arm_id", EmitDefaultValue = false)]
        public string ArmId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSuctionsRequestArgs {\n");
            sb.Append("  RobotId: ").Append(RobotId).Append("\n");
            sb.Append("  ArmId: ").Append(ArmId).Append("\n");
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
            return Equals(input as GetSuctionsRequestArgs);
        }

        /// <summary>
        /// Returns true if GetSuctionsRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSuctionsRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSuctionsRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    RobotId == input.RobotId ||
                    (RobotId != null &&
                    RobotId.Equals(input.RobotId))
                ) && 
                (
                    ArmId == input.ArmId ||
                    (ArmId != null &&
                    ArmId.Equals(input.ArmId))
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
                if (RobotId != null)
                {
                    hashCode = hashCode * 59 + RobotId.GetHashCode();
                }
                if (ArmId != null)
                {
                    hashCode = hashCode * 59 + ArmId.GetHashCode();
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
