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
    /// Args(robot_id: str, end_effector_id: str, name: str, arm_id: Optional[str] &#x3D; None)
    /// </summary>
    [DataContract(Name = "AddApUsingRobotRequestArgs")]
    public partial class AddApUsingRobotRequestArgs : IEquatable<AddApUsingRobotRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddApUsingRobotRequestArgs" /> class.
        /// </summary>
        [JsonConstructor]
        protected AddApUsingRobotRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddApUsingRobotRequestArgs" /> class.
        /// </summary>
        /// <param name="robotId">robotId (required).</param>
        /// <param name="endEffectorId">endEffectorId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="armId">armId.</param>
        public AddApUsingRobotRequestArgs(string robotId = default, string endEffectorId = default, string name = default, string armId = default)
        {
            // to ensure "robotId" is required (not null)
            if (robotId == null)
            {
                throw new ArgumentNullException("robotId is a required property for AddApUsingRobotRequestArgs and cannot be null");
            }
            RobotId = robotId;
            // to ensure "endEffectorId" is required (not null)
            if (endEffectorId == null)
            {
                throw new ArgumentNullException("endEffectorId is a required property for AddApUsingRobotRequestArgs and cannot be null");
            }
            EndEffectorId = endEffectorId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddApUsingRobotRequestArgs and cannot be null");
            }
            Name = name;
            ArmId = armId;
        }

        /// <summary>
        /// Gets or Sets RobotId
        /// </summary>
        [DataMember(Name = "robot_id", IsRequired = true, EmitDefaultValue = true)]
        public string RobotId { get; set; }

        /// <summary>
        /// Gets or Sets EndEffectorId
        /// </summary>
        [DataMember(Name = "end_effector_id", IsRequired = true, EmitDefaultValue = true)]
        public string EndEffectorId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

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
            sb.Append("class AddApUsingRobotRequestArgs {\n");
            sb.Append("  RobotId: ").Append(RobotId).Append("\n");
            sb.Append("  EndEffectorId: ").Append(EndEffectorId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals(input as AddApUsingRobotRequestArgs);
        }

        /// <summary>
        /// Returns true if AddApUsingRobotRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of AddApUsingRobotRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddApUsingRobotRequestArgs input)
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
                    EndEffectorId == input.EndEffectorId ||
                    (EndEffectorId != null &&
                    EndEffectorId.Equals(input.EndEffectorId))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
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
                if (EndEffectorId != null)
                {
                    hashCode = hashCode * 59 + EndEffectorId.GetHashCode();
                }
                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
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
