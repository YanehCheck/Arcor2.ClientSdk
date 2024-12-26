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
    /// Request(id: int, args: arcor2_arserver_data.rpc.project.AddActionPointJointsUsingRobot.Request.Args, dry_run: bool &#x3D; False)
    /// </summary>
    [DataContract(Name = "AddActionPointJointsUsingRobotRequest")]
    public partial class AddActionPointJointsUsingRobotRequest : IEquatable<AddActionPointJointsUsingRobotRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddActionPointJointsUsingRobotRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected AddActionPointJointsUsingRobotRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddActionPointJointsUsingRobotRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="request">request (required).</param>
        /// <param name="args">args (required).</param>
        /// <param name="dryRun">dryRun (default to false).</param>
        public AddActionPointJointsUsingRobotRequest(int id = default, string request = default, AddActionPointJointsUsingRobotRequestArgs args = default, bool dryRun = false)
        {
            Id = id;
            // to ensure "request" is required (not null)
            if (request == null)
            {
                throw new ArgumentNullException("request is a required property for AddActionPointJointsUsingRobotRequest and cannot be null");
            }
            Request = request;
            // to ensure "args" is required (not null)
            if (args == null)
            {
                throw new ArgumentNullException("args is a required property for AddActionPointJointsUsingRobotRequest and cannot be null");
            }
            Args = args;
            DryRun = dryRun;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", IsRequired = true, EmitDefaultValue = true)]
        public string Request { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name = "args", IsRequired = true, EmitDefaultValue = true)]
        public AddActionPointJointsUsingRobotRequestArgs Args { get; set; }

        /// <summary>
        /// Gets or Sets DryRun
        /// </summary>
        [DataMember(Name = "dry_run", EmitDefaultValue = true)]
        public bool DryRun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddActionPointJointsUsingRobotRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
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
            return Equals(input as AddActionPointJointsUsingRobotRequest);
        }

        /// <summary>
        /// Returns true if AddActionPointJointsUsingRobotRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddActionPointJointsUsingRobotRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddActionPointJointsUsingRobotRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Id == input.Id ||
                    Id.Equals(input.Id)
                ) && 
                (
                    Request == input.Request ||
                    (Request != null &&
                    Request.Equals(input.Request))
                ) && 
                (
                    Args == input.Args ||
                    (Args != null &&
                    Args.Equals(input.Args))
                ) && 
                (
                    DryRun == input.DryRun ||
                    DryRun.Equals(input.DryRun)
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
                hashCode = hashCode * 59 + Id.GetHashCode();
                if (Request != null)
                {
                    hashCode = hashCode * 59 + Request.GetHashCode();
                }
                if (Args != null)
                {
                    hashCode = hashCode * 59 + Args.GetHashCode();
                }
                hashCode = hashCode * 59 + DryRun.GetHashCode();
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
