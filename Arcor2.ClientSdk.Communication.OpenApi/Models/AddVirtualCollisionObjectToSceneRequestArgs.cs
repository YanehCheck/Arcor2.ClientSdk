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
    /// Args(name: str, pose: arcor2.data.common.Pose, model: arcor2.data.object_type.ObjectModel)
    /// </summary>
    [DataContract(Name = "AddVirtualCollisionObjectToSceneRequestArgs")]
    public partial class AddVirtualCollisionObjectToSceneRequestArgs : IEquatable<AddVirtualCollisionObjectToSceneRequestArgs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddVirtualCollisionObjectToSceneRequestArgs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddVirtualCollisionObjectToSceneRequestArgs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddVirtualCollisionObjectToSceneRequestArgs" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="pose">pose (required).</param>
        /// <param name="model">model (required).</param>
        public AddVirtualCollisionObjectToSceneRequestArgs(string name = default(string), Pose pose = default(Pose), ObjectModel model = default(ObjectModel))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddVirtualCollisionObjectToSceneRequestArgs and cannot be null");
            }
            this.Name = name;
            // to ensure "pose" is required (not null)
            if (pose == null)
            {
                throw new ArgumentNullException("pose is a required property for AddVirtualCollisionObjectToSceneRequestArgs and cannot be null");
            }
            this.Pose = pose;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for AddVirtualCollisionObjectToSceneRequestArgs and cannot be null");
            }
            this.Model = model;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Pose
        /// </summary>
        [DataMember(Name = "pose", IsRequired = true, EmitDefaultValue = true)]
        public Pose Pose { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public ObjectModel Model { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddVirtualCollisionObjectToSceneRequestArgs {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pose: ").Append(Pose).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
            return this.Equals(input as AddVirtualCollisionObjectToSceneRequestArgs);
        }

        /// <summary>
        /// Returns true if AddVirtualCollisionObjectToSceneRequestArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of AddVirtualCollisionObjectToSceneRequestArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddVirtualCollisionObjectToSceneRequestArgs input)
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
                    this.Pose == input.Pose ||
                    (this.Pose != null &&
                    this.Pose.Equals(input.Pose))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
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
                if (this.Pose != null)
                {
                    hashCode = (hashCode * 59) + this.Pose.GetHashCode();
                }
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
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
