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
    /// Project(name: &#39;str&#39;, scene_id: &#39;str&#39;, description: &#39;str&#39; &#x3D; &lt;factory&gt;, has_logic: &#39;bool&#39; &#x3D; True, created: &#39;Optional[datetime]&#39; &#x3D; None, modified: &#39;Optional[datetime]&#39; &#x3D; None, int_modified: &#39;Optional[datetime]&#39; &#x3D; None, id: &#39;str&#39; &#x3D; &#39;&#39;, action_points: &#39;list[ActionPoint]&#39; &#x3D; &lt;factory&gt;, parameters: &#39;list[ProjectParameter]&#39; &#x3D; &lt;factory&gt;, functions: &#39;list[ProjectFunction]&#39; &#x3D; &lt;factory&gt;, logic: &#39;list[LogicItem]&#39; &#x3D; &lt;factory&gt;, object_overrides: &#39;list[SceneObjectOverride]&#39; &#x3D; &lt;factory&gt;, project_objects_ids: &#39;Optional[list[str]]&#39; &#x3D; None)
    /// </summary>
    [DataContract(Name = "Project")]
    public partial class Project : IEquatable<Project>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Project() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="sceneId">sceneId (required).</param>
        /// <param name="description">description (default to &quot;&quot;).</param>
        /// <param name="hasLogic">hasLogic (default to true).</param>
        /// <param name="created">created.</param>
        /// <param name="modified">modified.</param>
        /// <param name="intModified">intModified.</param>
        /// <param name="id">id (default to &quot;&quot;).</param>
        /// <param name="actionPoints">actionPoints.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="functions">functions.</param>
        /// <param name="logic">logic.</param>
        /// <param name="objectOverrides">objectOverrides.</param>
        /// <param name="projectObjectsIds">projectObjectsIds.</param>
        public Project(string name = default(string), string sceneId = default(string), string description = @"", bool hasLogic = true, DateTime created = default(DateTime), DateTime modified = default(DateTime), DateTime intModified = default(DateTime), string id = @"", List<ActionPoint> actionPoints = default(List<ActionPoint>), List<ProjectParameter> parameters = default(List<ProjectParameter>), List<ProjectFunction> functions = default(List<ProjectFunction>), List<LogicItem> logic = default(List<LogicItem>), List<SceneObjectOverride> objectOverrides = default(List<SceneObjectOverride>), List<string> projectObjectsIds = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Project and cannot be null");
            }
            this.Name = name;
            // to ensure "sceneId" is required (not null)
            if (sceneId == null)
            {
                throw new ArgumentNullException("sceneId is a required property for Project and cannot be null");
            }
            this.SceneId = sceneId;
            // use default value if no "description" provided
            this.Description = description ?? @"";
            this.HasLogic = hasLogic;
            this.Created = created;
            this.Modified = modified;
            this.IntModified = intModified;
            // use default value if no "id" provided
            this.Id = id ?? @"";
            this.ActionPoints = actionPoints;
            this.Parameters = parameters;
            this.Functions = functions;
            this.Logic = logic;
            this.ObjectOverrides = objectOverrides;
            this.ProjectObjectsIds = projectObjectsIds;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SceneId
        /// </summary>
        [DataMember(Name = "scene_id", IsRequired = true, EmitDefaultValue = true)]
        public string SceneId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets HasLogic
        /// </summary>
        [DataMember(Name = "has_logic", EmitDefaultValue = true)]
        public bool HasLogic { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets IntModified
        /// </summary>
        [DataMember(Name = "int_modified", EmitDefaultValue = false)]
        public DateTime IntModified { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ActionPoints
        /// </summary>
        [DataMember(Name = "action_points", EmitDefaultValue = false)]
        public List<ActionPoint> ActionPoints { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<ProjectParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Functions
        /// </summary>
        [DataMember(Name = "functions", EmitDefaultValue = false)]
        public List<ProjectFunction> Functions { get; set; }

        /// <summary>
        /// Gets or Sets Logic
        /// </summary>
        [DataMember(Name = "logic", EmitDefaultValue = false)]
        public List<LogicItem> Logic { get; set; }

        /// <summary>
        /// Gets or Sets ObjectOverrides
        /// </summary>
        [DataMember(Name = "object_overrides", EmitDefaultValue = false)]
        public List<SceneObjectOverride> ObjectOverrides { get; set; }

        /// <summary>
        /// Gets or Sets ProjectObjectsIds
        /// </summary>
        [DataMember(Name = "project_objects_ids", EmitDefaultValue = false)]
        public List<string> ProjectObjectsIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SceneId: ").Append(SceneId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HasLogic: ").Append(HasLogic).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  IntModified: ").Append(IntModified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActionPoints: ").Append(ActionPoints).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
            sb.Append("  Logic: ").Append(Logic).Append("\n");
            sb.Append("  ObjectOverrides: ").Append(ObjectOverrides).Append("\n");
            sb.Append("  ProjectObjectsIds: ").Append(ProjectObjectsIds).Append("\n");
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
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="input">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project input)
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
                    this.SceneId == input.SceneId ||
                    (this.SceneId != null &&
                    this.SceneId.Equals(input.SceneId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HasLogic == input.HasLogic ||
                    this.HasLogic.Equals(input.HasLogic)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.IntModified == input.IntModified ||
                    (this.IntModified != null &&
                    this.IntModified.Equals(input.IntModified))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ActionPoints == input.ActionPoints ||
                    this.ActionPoints != null &&
                    input.ActionPoints != null &&
                    this.ActionPoints.SequenceEqual(input.ActionPoints)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
                ) && 
                (
                    this.Logic == input.Logic ||
                    this.Logic != null &&
                    input.Logic != null &&
                    this.Logic.SequenceEqual(input.Logic)
                ) && 
                (
                    this.ObjectOverrides == input.ObjectOverrides ||
                    this.ObjectOverrides != null &&
                    input.ObjectOverrides != null &&
                    this.ObjectOverrides.SequenceEqual(input.ObjectOverrides)
                ) && 
                (
                    this.ProjectObjectsIds == input.ProjectObjectsIds ||
                    this.ProjectObjectsIds != null &&
                    input.ProjectObjectsIds != null &&
                    this.ProjectObjectsIds.SequenceEqual(input.ProjectObjectsIds)
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
                if (this.SceneId != null)
                {
                    hashCode = (hashCode * 59) + this.SceneId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasLogic.GetHashCode();
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Modified != null)
                {
                    hashCode = (hashCode * 59) + this.Modified.GetHashCode();
                }
                if (this.IntModified != null)
                {
                    hashCode = (hashCode * 59) + this.IntModified.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ActionPoints != null)
                {
                    hashCode = (hashCode * 59) + this.ActionPoints.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
                }
                if (this.Logic != null)
                {
                    hashCode = (hashCode * 59) + this.Logic.GetHashCode();
                }
                if (this.ObjectOverrides != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectOverrides.GetHashCode();
                }
                if (this.ProjectObjectsIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectObjectsIds.GetHashCode();
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
