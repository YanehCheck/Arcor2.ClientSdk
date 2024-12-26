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
    /// Args(action_point_id: str, new_position: arcor2.data.common.Position)
    /// </summary>
    [DataContract(Name = "UpdateActionPointPositionRequestArgs")]
    public partial class UpdateActionPointPositionRequestArgs : IEquatable<UpdateActionPointPositionRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActionPointPositionRequestArgs" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateActionPointPositionRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActionPointPositionRequestArgs" /> class.
        /// </summary>
        /// <param name="actionPointId">actionPointId (required).</param>
        /// <param name="newPosition">newPosition (required).</param>
        public UpdateActionPointPositionRequestArgs(string actionPointId = default(string), Position newPosition = default(Position))
        {
            // to ensure "actionPointId" is required (not null)
            if (actionPointId == null)
            {
                throw new ArgumentNullException("actionPointId is a required property for UpdateActionPointPositionRequestArgs and cannot be null");
            }
            this.ActionPointId = actionPointId;
            // to ensure "newPosition" is required (not null)
            if (newPosition == null)
            {
                throw new ArgumentNullException("newPosition is a required property for UpdateActionPointPositionRequestArgs and cannot be null");
            }
            this.NewPosition = newPosition;
        }

        /// <summary>
        /// Gets or Sets ActionPointId
        /// </summary>
        [DataMember(Name = "action_point_id", IsRequired = true, EmitDefaultValue = true)]
        public string ActionPointId { get; set; }

        /// <summary>
        /// Gets or Sets NewPosition
        /// </summary>
        [DataMember(Name = "new_position", IsRequired = true, EmitDefaultValue = true)]
        public Position NewPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateActionPointPositionRequestArgs {\n");
            sb.Append("  ActionPointId: ").Append(ActionPointId).Append("\n");
            sb.Append("  NewPosition: ").Append(NewPosition).Append("\n");
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
            return this.Equals(input as UpdateActionPointPositionRequestArgs);
        }

        /// <summary>
        /// Returns true if UpdateActionPointPositionRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateActionPointPositionRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateActionPointPositionRequestArgs input)
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
                    this.NewPosition == input.NewPosition ||
                    (this.NewPosition != null &&
                    this.NewPosition.Equals(input.NewPosition))
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
                if (this.NewPosition != null)
                {
                    hashCode = (hashCode * 59) + this.NewPosition.GetHashCode();
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
