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
    /// Args(name: str, position: arcor2.data.common.Position, parent: Optional[str] &#x3D; None)
    /// </summary>
    [DataContract(Name = "AddActionPointRequestArgs")]
    public partial class AddActionPointRequestArgs : IEquatable<AddActionPointRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddActionPointRequestArgs" /> class.
        /// </summary>
        [JsonConstructor]
        protected AddActionPointRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddActionPointRequestArgs" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="parent">parent.</param>
        public AddActionPointRequestArgs(string name = default, Position position = default, string parent = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddActionPointRequestArgs and cannot be null");
            }
            Name = name;
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new ArgumentNullException("position is a required property for AddActionPointRequestArgs and cannot be null");
            }
            Position = position;
            Parent = parent;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = true)]
        public Position Position { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public string Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddActionPointRequestArgs {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return Equals(input as AddActionPointRequestArgs);
        }

        /// <summary>
        /// Returns true if AddActionPointRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of AddActionPointRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddActionPointRequestArgs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Position == input.Position ||
                    (Position != null &&
                    Position.Equals(input.Position))
                ) && 
                (
                    Parent == input.Parent ||
                    (Parent != null &&
                    Parent.Equals(input.Parent))
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
                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }
                if (Position != null)
                {
                    hashCode = hashCode * 59 + Position.GetHashCode();
                }
                if (Parent != null)
                {
                    hashCode = hashCode * 59 + Parent.GetHashCode();
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
