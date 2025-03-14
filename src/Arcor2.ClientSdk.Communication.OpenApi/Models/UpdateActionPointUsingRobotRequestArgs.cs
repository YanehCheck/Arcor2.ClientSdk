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
    /// Args(action_point_id: str, robot: arcor2.data.rpc.common.RobotArg)
    /// </summary>
    [DataContract(Name = "UpdateActionPointUsingRobotRequestArgs")]
    public partial class UpdateActionPointUsingRobotRequestArgs : IEquatable<UpdateActionPointUsingRobotRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActionPointUsingRobotRequestArgs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateActionPointUsingRobotRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActionPointUsingRobotRequestArgs" /> class.
        /// </summary>
        /// <param name="actionPointId">actionPointId (required).</param>
        /// <param name="robot">robot (required).</param>
        public UpdateActionPointUsingRobotRequestArgs(string actionPointId = default(string), RobotArg robot = default(RobotArg))
        {
            // to ensure "actionPointId" is required (not null)
            if (actionPointId == null)
            {
                throw new ArgumentNullException("actionPointId is a required property for UpdateActionPointUsingRobotRequestArgs and cannot be null");
            }
            this.ActionPointId = actionPointId;
            // to ensure "robot" is required (not null)
            if (robot == null)
            {
                throw new ArgumentNullException("robot is a required property for UpdateActionPointUsingRobotRequestArgs and cannot be null");
            }
            this.Robot = robot;
        }

        /// <summary>
        /// Gets or Sets ActionPointId
        /// </summary>
        [DataMember(Name = "action_point_id", IsRequired = true, EmitDefaultValue = true)]
        public string ActionPointId { get; set; }

        /// <summary>
        /// Gets or Sets Robot
        /// </summary>
        [DataMember(Name = "robot", IsRequired = true, EmitDefaultValue = true)]
        public RobotArg Robot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateActionPointUsingRobotRequestArgs {\n");
            sb.Append("  ActionPointId: ").Append(ActionPointId).Append("\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
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
            return this.Equals(input as UpdateActionPointUsingRobotRequestArgs);
        }

        /// <summary>
        /// Returns true if UpdateActionPointUsingRobotRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateActionPointUsingRobotRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateActionPointUsingRobotRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionPointId == input.ActionPointId ||
                    (this.ActionPointId != null &&
                    this.ActionPointId.Equals(input.ActionPointId))
                ) && 
                (
                    this.Robot == input.Robot ||
                    (this.Robot != null &&
                    this.Robot.Equals(input.Robot))
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
                if (this.ActionPointId != null)
                {
                    hashCode = (hashCode * 59) + this.ActionPointId.GetHashCode();
                }
                if (this.Robot != null)
                {
                    hashCode = (hashCode * 59) + this.Robot.GetHashCode();
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
