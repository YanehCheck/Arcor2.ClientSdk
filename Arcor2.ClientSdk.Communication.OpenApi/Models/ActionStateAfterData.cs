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

namespace Arcor2.ClientSdk.Communication.OpenApi.Models
{
    /// <summary>
    /// Data(action_id: str, results: Optional[list[str]] &#x3D; None)
    /// </summary>
    [DataContract(Name = "ActionStateAfterData")]
    public partial class ActionStateAfterData : IEquatable<ActionStateAfterData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionStateAfterData" /> class.
        /// </summary>
        [JsonConstructor]
        protected ActionStateAfterData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionStateAfterData" /> class.
        /// </summary>
        /// <param name="actionId">actionId (required).</param>
        /// <param name="results">results.</param>
        public ActionStateAfterData(string actionId = default, List<string> results = default)
        {
            // to ensure "actionId" is required (not null)
            if (actionId == null)
            {
                throw new ArgumentNullException("actionId is a required property for ActionStateAfterData and cannot be null");
            }
            ActionId = actionId;
            Results = results;
        }

        /// <summary>
        /// Gets or Sets ActionId
        /// </summary>
        [DataMember(Name = "action_id", IsRequired = true, EmitDefaultValue = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<string> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActionStateAfterData {\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return Equals(input as ActionStateAfterData);
        }

        /// <summary>
        /// Returns true if ActionStateAfterData instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionStateAfterData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionStateAfterData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    ActionId == input.ActionId ||
                    (ActionId != null &&
                    ActionId.Equals(input.ActionId))
                ) && 
                (
                    Results == input.Results ||
                    (Results != null &&
                     input.Results != null &&
                     Results.SequenceEqual(input.Results))
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
                if (ActionId != null)
                {
                    hashCode = hashCode * 59 + ActionId.GetHashCode();
                }
                if (Results != null)
                {
                    hashCode = hashCode * 59 + Results.GetHashCode();
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
