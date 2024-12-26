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
    /// Project(name: &#39;str&#39;, scene_id: &#39;str&#39;, description: &#39;str&#39; &#x3D; &lt;factory&gt;, has_logic: &#39;bool&#39; &#x3D; True, created: &#39;Optional[datetime]&#39; &#x3D; None, modified: &#39;Optional[datetime]&#39; &#x3D; None, int_modified: &#39;Optional[datetime]&#39; &#x3D; None, id: &#39;str&#39; &#x3D; &#39;&#39;, action_points: &#39;list[ActionPoint]&#39; &#x3D; &lt;factory&gt;, parameters: &#39;list[ProjectParameter]&#39; &#x3D; &lt;factory&gt;, functions: &#39;list[ProjectFunction]&#39; &#x3D; &lt;factory&gt;, logic: &#39;list[LogicItem]&#39; &#x3D; &lt;factory&gt;, object_overrides: &#39;list[SceneObjectOverride]&#39; &#x3D; &lt;factory&gt;, project_objects_ids: &#39;Optional[list[str]]&#39; &#x3D; None)
    /// </summary>
    [DataContract(Name = "Project")]
    public partial class Project : IEquatable<Project>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        [JsonConstructor]
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
        public Project(string name = default, string sceneId = default, string description = @"", bool hasLogic = true, DateTime created = default, DateTime modified = default, DateTime intModified = default, string id = @"", List<ActionPoint> actionPoints = default, List<ProjectParameter> parameters = default, List<ProjectFunction> functions = default, List<LogicItem> logic = default, List<SceneObjectOverride> objectOverrides = default, List<string> projectObjectsIds = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Project and cannot be null");
            }
            Name = name;
            // to ensure "sceneId" is required (not null)
            if (sceneId == null)
            {
                throw new ArgumentNullException("sceneId is a required property for Project and cannot be null");
            }
            SceneId = sceneId;
            // use default value if no "description" provided
            Description = description ?? @"";
            HasLogic = hasLogic;
            Created = created;
            Modified = modified;
            IntModified = intModified;
            // use default value if no "id" provided
            Id = id ?? @"";
            ActionPoints = actionPoints;
            Parameters = parameters;
            Functions = functions;
            Logic = logic;
            ObjectOverrides = objectOverrides;
            ProjectObjectsIds = projectObjectsIds;
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Project);
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
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    SceneId == input.SceneId ||
                    (SceneId != null &&
                    SceneId.Equals(input.SceneId))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    HasLogic == input.HasLogic ||
                    HasLogic.Equals(input.HasLogic)
                ) && 
                (
                    Created == input.Created ||
                    (Created != null &&
                    Created.Equals(input.Created))
                ) && 
                (
                    Modified == input.Modified ||
                    (Modified != null &&
                    Modified.Equals(input.Modified))
                ) && 
                (
                    IntModified == input.IntModified ||
                    (IntModified != null &&
                    IntModified.Equals(input.IntModified))
                ) && 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    ActionPoints == input.ActionPoints ||
                    (ActionPoints != null &&
                     input.ActionPoints != null &&
                     ActionPoints.SequenceEqual(input.ActionPoints))
                ) && 
                (
                    Parameters == input.Parameters ||
                    (Parameters != null &&
                     input.Parameters != null &&
                     Parameters.SequenceEqual(input.Parameters))
                ) && 
                (
                    Functions == input.Functions ||
                    (Functions != null &&
                     input.Functions != null &&
                     Functions.SequenceEqual(input.Functions))
                ) && 
                (
                    Logic == input.Logic ||
                    (Logic != null &&
                     input.Logic != null &&
                     Logic.SequenceEqual(input.Logic))
                ) && 
                (
                    ObjectOverrides == input.ObjectOverrides ||
                    (ObjectOverrides != null &&
                     input.ObjectOverrides != null &&
                     ObjectOverrides.SequenceEqual(input.ObjectOverrides))
                ) && 
                (
                    ProjectObjectsIds == input.ProjectObjectsIds ||
                    (ProjectObjectsIds != null &&
                     input.ProjectObjectsIds != null &&
                     ProjectObjectsIds.SequenceEqual(input.ProjectObjectsIds))
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
                if (SceneId != null)
                {
                    hashCode = hashCode * 59 + SceneId.GetHashCode();
                }
                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }
                hashCode = hashCode * 59 + HasLogic.GetHashCode();
                if (Created != null)
                {
                    hashCode = hashCode * 59 + Created.GetHashCode();
                }
                if (Modified != null)
                {
                    hashCode = hashCode * 59 + Modified.GetHashCode();
                }
                if (IntModified != null)
                {
                    hashCode = hashCode * 59 + IntModified.GetHashCode();
                }
                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }
                if (ActionPoints != null)
                {
                    hashCode = hashCode * 59 + ActionPoints.GetHashCode();
                }
                if (Parameters != null)
                {
                    hashCode = hashCode * 59 + Parameters.GetHashCode();
                }
                if (Functions != null)
                {
                    hashCode = hashCode * 59 + Functions.GetHashCode();
                }
                if (Logic != null)
                {
                    hashCode = hashCode * 59 + Logic.GetHashCode();
                }
                if (ObjectOverrides != null)
                {
                    hashCode = hashCode * 59 + ObjectOverrides.GetHashCode();
                }
                if (ProjectObjectsIds != null)
                {
                    hashCode = hashCode * 59 + ProjectObjectsIds.GetHashCode();
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
