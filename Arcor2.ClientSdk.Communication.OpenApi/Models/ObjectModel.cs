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
using Newtonsoft.Json.Converters;

namespace Arcor2.ClientSdk.Communication.OpenApi.Models
{
    /// <summary>
    /// ObjectModel(type: arcor2.data.object_type.Model3dType, box: Optional[arcor2.data.object_type.Box] &#x3D; None, cylinder: Optional[arcor2.data.object_type.Cylinder] &#x3D; None, sphere: Optional[arcor2.data.object_type.Sphere] &#x3D; None, mesh: Optional[arcor2.data.object_type.Mesh] &#x3D; None)
    /// </summary>
    [DataContract(Name = "ObjectModel")]
    public partial class ObjectModel : IEquatable<ObjectModel>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Box for value: Box
            /// </summary>
            [EnumMember(Value = "Box")]
            Box = 2,

            /// <summary>
            /// Enum Cylinder for value: Cylinder
            /// </summary>
            [EnumMember(Value = "Cylinder")]
            Cylinder = 3,

            /// <summary>
            /// Enum Sphere for value: Sphere
            /// </summary>
            [EnumMember(Value = "Sphere")]
            Sphere = 4,

            /// <summary>
            /// Enum Mesh for value: Mesh
            /// </summary>
            [EnumMember(Value = "Mesh")]
            Mesh = 5
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectModel" /> class.
        /// </summary>
        [JsonConstructor]
        protected ObjectModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectModel" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="box">box.</param>
        /// <param name="cylinder">cylinder.</param>
        /// <param name="sphere">sphere.</param>
        /// <param name="mesh">mesh.</param>
        public ObjectModel(TypeEnum type = default, Box box = default, Cylinder cylinder = default, Sphere sphere = default, Mesh mesh = default)
        {
            Type = type;
            Box = box;
            Cylinder = cylinder;
            Sphere = sphere;
            Mesh = mesh;
        }

        /// <summary>
        /// Gets or Sets Box
        /// </summary>
        [DataMember(Name = "box", EmitDefaultValue = false)]
        public Box Box { get; set; }

        /// <summary>
        /// Gets or Sets Cylinder
        /// </summary>
        [DataMember(Name = "cylinder", EmitDefaultValue = false)]
        public Cylinder Cylinder { get; set; }

        /// <summary>
        /// Gets or Sets Sphere
        /// </summary>
        [DataMember(Name = "sphere", EmitDefaultValue = false)]
        public Sphere Sphere { get; set; }

        /// <summary>
        /// Gets or Sets Mesh
        /// </summary>
        [DataMember(Name = "mesh", EmitDefaultValue = false)]
        public Mesh Mesh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Box: ").Append(Box).Append("\n");
            sb.Append("  Cylinder: ").Append(Cylinder).Append("\n");
            sb.Append("  Sphere: ").Append(Sphere).Append("\n");
            sb.Append("  Mesh: ").Append(Mesh).Append("\n");
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
            return Equals(input as ObjectModel);
        }

        /// <summary>
        /// Returns true if ObjectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectModel input)
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
                    Box == input.Box ||
                    (Box != null &&
                    Box.Equals(input.Box))
                ) && 
                (
                    Cylinder == input.Cylinder ||
                    (Cylinder != null &&
                    Cylinder.Equals(input.Cylinder))
                ) && 
                (
                    Sphere == input.Sphere ||
                    (Sphere != null &&
                    Sphere.Equals(input.Sphere))
                ) && 
                (
                    Mesh == input.Mesh ||
                    (Mesh != null &&
                    Mesh.Equals(input.Mesh))
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
                if (Box != null)
                {
                    hashCode = hashCode * 59 + Box.GetHashCode();
                }
                if (Cylinder != null)
                {
                    hashCode = hashCode * 59 + Cylinder.GetHashCode();
                }
                if (Sphere != null)
                {
                    hashCode = hashCode * 59 + Sphere.GetHashCode();
                }
                if (Mesh != null)
                {
                    hashCode = hashCode * 59 + Mesh.GetHashCode();
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
