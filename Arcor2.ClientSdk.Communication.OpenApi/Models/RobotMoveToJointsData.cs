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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Arcor2.ClientSdk.Communication.OpenApi.Models
{
    /// <summary>
    /// Data(move_event_type: arcor2_arserver_data.events.robot.RobotMoveToData.MoveEventType, robot_id: str, target_joints: list[arcor2.data.common.Joint], safe: bool, message: Optional[str] &#x3D; None, arm_id: Optional[str] &#x3D; None)
    /// </summary>
    [DataContract(Name = "RobotMoveToJointsData")]
    public partial class RobotMoveToJointsData : IEquatable<RobotMoveToJointsData>, IValidatableObject
    {
        /// <summary>
        /// Defines MoveEventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MoveEventTypeEnum
        {
            /// <summary>
            /// Enum Start for value: start
            /// </summary>
            [EnumMember(Value = "start")]
            Start = 1,

            /// <summary>
            /// Enum End for value: end
            /// </summary>
            [EnumMember(Value = "end")]
            End = 2,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3
        }


        /// <summary>
        /// Gets or Sets MoveEventType
        /// </summary>
        [DataMember(Name = "move_event_type", IsRequired = true, EmitDefaultValue = true)]
        public MoveEventTypeEnum MoveEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotMoveToJointsData" /> class.
        /// </summary>
        [JsonConstructor]
        protected RobotMoveToJointsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotMoveToJointsData" /> class.
        /// </summary>
        /// <param name="moveEventType">moveEventType (required).</param>
        /// <param name="robotId">robotId (required).</param>
        /// <param name="targetJoints">targetJoints (required).</param>
        /// <param name="safe">safe (required).</param>
        /// <param name="message">message.</param>
        /// <param name="armId">armId.</param>
        public RobotMoveToJointsData(MoveEventTypeEnum moveEventType = default(MoveEventTypeEnum), string robotId = default(string), List<Joint> targetJoints = default(List<Joint>), bool safe = default(bool), string message = default(string), string armId = default(string))
        {
            this.MoveEventType = moveEventType;
            // to ensure "robotId" is required (not null)
            if (robotId == null)
            {
                throw new ArgumentNullException("robotId is a required property for RobotMoveToJointsData and cannot be null");
            }
            this.RobotId = robotId;
            // to ensure "targetJoints" is required (not null)
            if (targetJoints == null)
            {
                throw new ArgumentNullException("targetJoints is a required property for RobotMoveToJointsData and cannot be null");
            }
            this.TargetJoints = targetJoints;
            this.Safe = safe;
            this.Message = message;
            this.ArmId = armId;
        }

        /// <summary>
        /// Gets or Sets RobotId
        /// </summary>
        [DataMember(Name = "robot_id", IsRequired = true, EmitDefaultValue = true)]
        public string RobotId { get; set; }

        /// <summary>
        /// Gets or Sets TargetJoints
        /// </summary>
        [DataMember(Name = "target_joints", IsRequired = true, EmitDefaultValue = true)]
        public List<Joint> TargetJoints { get; set; }

        /// <summary>
        /// Gets or Sets Safe
        /// </summary>
        [DataMember(Name = "safe", IsRequired = true, EmitDefaultValue = true)]
        public bool Safe { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

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
            sb.Append("class RobotMoveToJointsData {\n");
            sb.Append("  MoveEventType: ").Append(MoveEventType).Append("\n");
            sb.Append("  RobotId: ").Append(RobotId).Append("\n");
            sb.Append("  TargetJoints: ").Append(TargetJoints).Append("\n");
            sb.Append("  Safe: ").Append(Safe).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RobotMoveToJointsData);
        }

        /// <summary>
        /// Returns true if RobotMoveToJointsData instances are equal
        /// </summary>
        /// <param name="input">Instance of RobotMoveToJointsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotMoveToJointsData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MoveEventType == input.MoveEventType ||
                    this.MoveEventType.Equals(input.MoveEventType)
                ) && 
                (
                    this.RobotId == input.RobotId ||
                    (this.RobotId != null &&
                    this.RobotId.Equals(input.RobotId))
                ) && 
                (
                    this.TargetJoints == input.TargetJoints ||
                    this.TargetJoints != null &&
                    input.TargetJoints != null &&
                    this.TargetJoints.SequenceEqual(input.TargetJoints)
                ) && 
                (
                    this.Safe == input.Safe ||
                    this.Safe.Equals(input.Safe)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ArmId == input.ArmId ||
                    (this.ArmId != null &&
                    this.ArmId.Equals(input.ArmId))
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
                hashCode = (hashCode * 59) + this.MoveEventType.GetHashCode();
                if (this.RobotId != null)
                {
                    hashCode = (hashCode * 59) + this.RobotId.GetHashCode();
                }
                if (this.TargetJoints != null)
                {
                    hashCode = (hashCode * 59) + this.TargetJoints.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Safe.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.ArmId != null)
                {
                    hashCode = (hashCode * 59) + this.ArmId.GetHashCode();
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
