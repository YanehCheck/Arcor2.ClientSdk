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
    /// CollisionModels(boxes: list[arcor2.data.object_type.Box] &#x3D; &lt;factory&gt;, spheres: list[arcor2.data.object_type.Sphere] &#x3D; &lt;factory&gt;, cylinders: list[arcor2.data.object_type.Cylinder] &#x3D; &lt;factory&gt;, meshes: list[arcor2.data.object_type.Mesh] &#x3D; &lt;factory&gt;)
    /// </summary>
    [DataContract(Name = "CollisionModels")]
    public partial class CollisionModels : IEquatable<CollisionModels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModels" /> class.
        /// </summary>
        /// <param name="boxes">boxes.</param>
        /// <param name="spheres">spheres.</param>
        /// <param name="cylinders">cylinders.</param>
        /// <param name="meshes">meshes.</param>
        public CollisionModels(List<Box> boxes = default(List<Box>), List<Sphere> spheres = default(List<Sphere>), List<Cylinder> cylinders = default(List<Cylinder>), List<Mesh> meshes = default(List<Mesh>))
        {
            this.Boxes = boxes;
            this.Spheres = spheres;
            this.Cylinders = cylinders;
            this.Meshes = meshes;
        }

        /// <summary>
        /// Gets or Sets Boxes
        /// </summary>
        [DataMember(Name = "boxes", EmitDefaultValue = false)]
        public List<Box> Boxes { get; set; }

        /// <summary>
        /// Gets or Sets Spheres
        /// </summary>
        [DataMember(Name = "spheres", EmitDefaultValue = false)]
        public List<Sphere> Spheres { get; set; }

        /// <summary>
        /// Gets or Sets Cylinders
        /// </summary>
        [DataMember(Name = "cylinders", EmitDefaultValue = false)]
        public List<Cylinder> Cylinders { get; set; }

        /// <summary>
        /// Gets or Sets Meshes
        /// </summary>
        [DataMember(Name = "meshes", EmitDefaultValue = false)]
        public List<Mesh> Meshes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollisionModels {\n");
            sb.Append("  Boxes: ").Append(Boxes).Append("\n");
            sb.Append("  Spheres: ").Append(Spheres).Append("\n");
            sb.Append("  Cylinders: ").Append(Cylinders).Append("\n");
            sb.Append("  Meshes: ").Append(Meshes).Append("\n");
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
            return this.Equals(input as CollisionModels);
        }

        /// <summary>
        /// Returns true if CollisionModels instances are equal
        /// </summary>
        /// <param name="input">Instance of CollisionModels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollisionModels input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Boxes == input.Boxes ||
                    this.Boxes != null &&
                    input.Boxes != null &&
                    this.Boxes.SequenceEqual(input.Boxes)
                ) && 
                (
                    this.Spheres == input.Spheres ||
                    this.Spheres != null &&
                    input.Spheres != null &&
                    this.Spheres.SequenceEqual(input.Spheres)
                ) && 
                (
                    this.Cylinders == input.Cylinders ||
                    this.Cylinders != null &&
                    input.Cylinders != null &&
                    this.Cylinders.SequenceEqual(input.Cylinders)
                ) && 
                (
                    this.Meshes == input.Meshes ||
                    this.Meshes != null &&
                    input.Meshes != null &&
                    this.Meshes.SequenceEqual(input.Meshes)
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
                if (this.Boxes != null)
                {
                    hashCode = (hashCode * 59) + this.Boxes.GetHashCode();
                }
                if (this.Spheres != null)
                {
                    hashCode = (hashCode * 59) + this.Spheres.GetHashCode();
                }
                if (this.Cylinders != null)
                {
                    hashCode = (hashCode * 59) + this.Cylinders.GetHashCode();
                }
                if (this.Meshes != null)
                {
                    hashCode = (hashCode * 59) + this.Meshes.GetHashCode();
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
