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
    /// Flow(type: &#39;FlowTypes&#39; &#x3D; &lt;FlowTypes.DEFAULT: &#39;default&#39;&gt;, outputs: &#39;list[str]&#39; &#x3D; &lt;factory&gt;)
    /// </summary>
    [DataContract(Name = "Flow")]
    public partial class Flow : IEquatable<Flow>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Flow" /> class.
        /// </summary>
        /// <param name="type">type (default to TypeEnum.Default).</param>
        /// <param name="outputs">outputs.</param>
        public Flow(TypeEnum? type = TypeEnum.Default, List<string> outputs = default)
        {
            Type = type;
            Outputs = outputs;
        }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public List<string> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Flow {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return Equals(input as Flow);
        }

        /// <summary>
        /// Returns true if Flow instances are equal
        /// </summary>
        /// <param name="input">Instance of Flow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) && 
                (
                    Outputs == input.Outputs ||
                    (Outputs != null &&
                     input.Outputs != null &&
                     Outputs.SequenceEqual(input.Outputs))
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
                hashCode = hashCode * 59 + Type.GetHashCode();
                if (Outputs != null)
                {
                    hashCode = hashCode * 59 + Outputs.GetHashCode();
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
