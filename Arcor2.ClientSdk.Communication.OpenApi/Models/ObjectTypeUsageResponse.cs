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
    /// Response(id: int &#x3D; 0, result: bool &#x3D; True, messages: Optional[list[str]] &#x3D; None, data: Optional[set[str]] &#x3D; None)
    /// </summary>
    [DataContract(Name = "ObjectTypeUsageResponse")]
    public partial class ObjectTypeUsageResponse : IEquatable<ObjectTypeUsageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeUsageResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected ObjectTypeUsageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeUsageResponse" /> class.
        /// </summary>
        /// <param name="id">id (default to 0).</param>
        /// <param name="response">response (required).</param>
        /// <param name="result">result (default to true).</param>
        /// <param name="messages">messages.</param>
        /// <param name="data">data.</param>
        public ObjectTypeUsageResponse(int id = 0, string response = default, bool result = true, List<string> messages = default, List<string> data = default)
        {
            // to ensure "response" is required (not null)
            if (response == null)
            {
                throw new ArgumentNullException("response is a required property for ObjectTypeUsageResponse and cannot be null");
            }
            Response = response;
            Id = id;
            Result = result;
            Messages = messages;
            Data = data;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "response", IsRequired = true, EmitDefaultValue = true)]
        public string Response { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<string> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectTypeUsageResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return Equals(input as ObjectTypeUsageResponse);
        }

        /// <summary>
        /// Returns true if ObjectTypeUsageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectTypeUsageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectTypeUsageResponse input)
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
                    Response == input.Response ||
                    (Response != null &&
                    Response.Equals(input.Response))
                ) && 
                (
                    Result == input.Result ||
                    Result.Equals(input.Result)
                ) && 
                (
                    Messages == input.Messages ||
                    (Messages != null &&
                     input.Messages != null &&
                     Messages.SequenceEqual(input.Messages))
                ) && 
                (
                    Data == input.Data ||
                    (Data != null &&
                     input.Data != null &&
                     Data.SequenceEqual(input.Data))
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
                if (Response != null)
                {
                    hashCode = hashCode * 59 + Response.GetHashCode();
                }
                hashCode = hashCode * 59 + Result.GetHashCode();
                if (Messages != null)
                {
                    hashCode = hashCode * 59 + Messages.GetHashCode();
                }
                if (Data != null)
                {
                    hashCode = hashCode * 59 + Data.GetHashCode();
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
