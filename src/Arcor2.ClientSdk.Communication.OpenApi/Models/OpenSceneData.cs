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
    /// Data(scene: arcor2.data.common.Scene)
    /// </summary>
    [DataContract(Name = "OpenSceneData")]
    public partial class OpenSceneData : IEquatable<OpenSceneData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSceneData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenSceneData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSceneData" /> class.
        /// </summary>
        /// <param name="scene">scene (required).</param>
        public OpenSceneData(Scene scene = default(Scene))
        {
            // to ensure "scene" is required (not null)
            if (scene == null)
            {
                throw new ArgumentNullException("scene is a required property for OpenSceneData and cannot be null");
            }
            this.Scene = scene;
        }

        /// <summary>
        /// Gets or Sets Scene
        /// </summary>
        [DataMember(Name = "scene", IsRequired = true, EmitDefaultValue = true)]
        public Scene Scene { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenSceneData {\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
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
            return this.Equals(input as OpenSceneData);
        }

        /// <summary>
        /// Returns true if OpenSceneData instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenSceneData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenSceneData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
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
                if (this.Scene != null)
                {
                    hashCode = (hashCode * 59) + this.Scene.GetHashCode();
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
