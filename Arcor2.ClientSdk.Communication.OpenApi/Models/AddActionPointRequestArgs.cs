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
    /// Args(name: str, position: arcor2.data.common.Position, parent: Optional[str] &#x3D; None)
    /// </summary>
    [DataContract(Name = "AddActionPointRequestArgs")]
    public partial class AddActionPointRequestArgs : IEquatable<AddActionPointRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddActionPointRequestArgs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddActionPointRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddActionPointRequestArgs" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="parent">parent.</param>
        public AddActionPointRequestArgs(string name = default(string), Position position = default(Position), string parent = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddActionPointRequestArgs and cannot be null");
            }
            this.Name = name;
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new ArgumentNullException("position is a required property for AddActionPointRequestArgs and cannot be null");
            }
            this.Position = position;
            this.Parent = parent;
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddActionPointRequestArgs);
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Position != null)
                {
                    hashCode = (hashCode * 59) + this.Position.GetHashCode();
                }
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
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
