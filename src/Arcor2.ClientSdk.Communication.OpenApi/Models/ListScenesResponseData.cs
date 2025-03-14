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
    /// Data(id: &#39;str&#39;, name: &#39;str&#39;, created: &#39;datetime&#39;, modified: &#39;datetime&#39;, description: &#39;Optional[str]&#39; &#x3D; None, problems: Optional[list[str]] &#x3D; None)
    /// </summary>
    [DataContract(Name = "ListScenesResponseData")]
    public partial class ListScenesResponseData : IEquatable<ListScenesResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListScenesResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListScenesResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListScenesResponseData" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="modified">modified (required).</param>
        /// <param name="description">description.</param>
        /// <param name="problems">problems.</param>
        public ListScenesResponseData(string id = default(string), string name = default(string), DateTime created = default(DateTime), DateTime modified = default(DateTime), string description = default(string), List<string> problems = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ListScenesResponseData and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ListScenesResponseData and cannot be null");
            }
            this.Name = name;
            this.Created = created;
            this.Modified = modified;
            this.Description = description;
            this.Problems = problems;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Problems
        /// </summary>
        [DataMember(Name = "problems", EmitDefaultValue = false)]
        public List<string> Problems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListScenesResponseData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
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
            return this.Equals(input as ListScenesResponseData);
        }

        /// <summary>
        /// Returns true if ListScenesResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ListScenesResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListScenesResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Modified != null)
                {
                    hashCode = (hashCode * 59) + this.Modified.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Problems != null)
                {
                    hashCode = (hashCode * 59) + this.Problems.GetHashCode();
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
