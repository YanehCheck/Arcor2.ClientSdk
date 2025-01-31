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
    /// Data(version: str, api_version: str, supported_parameter_types: set[str] &#x3D; &lt;factory&gt;, supported_rpc_requests: set[str] &#x3D; &lt;factory&gt;)
    /// </summary>
    [DataContract(Name = "SystemInfoResponseData")]
    public partial class SystemInfoResponseData : IEquatable<SystemInfoResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemInfoResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoResponseData" /> class.
        /// </summary>
        /// <param name="varVersion">varVersion (required).</param>
        /// <param name="apiVersion">apiVersion (required).</param>
        /// <param name="supportedParameterTypes">supportedParameterTypes.</param>
        /// <param name="supportedRpcRequests">supportedRpcRequests.</param>
        public SystemInfoResponseData(string varVersion = default(string), string apiVersion = default(string), List<string> supportedParameterTypes = default(List<string>), List<string> supportedRpcRequests = default(List<string>))
        {
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for SystemInfoResponseData and cannot be null");
            }
            this.VarVersion = varVersion;
            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion is a required property for SystemInfoResponseData and cannot be null");
            }
            this.ApiVersion = apiVersion;
            this.SupportedParameterTypes = supportedParameterTypes;
            this.SupportedRpcRequests = supportedRpcRequests;
        }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "api_version", IsRequired = true, EmitDefaultValue = true)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets SupportedParameterTypes
        /// </summary>
        [DataMember(Name = "supported_parameter_types", EmitDefaultValue = false)]
        public List<string> SupportedParameterTypes { get; set; }

        /// <summary>
        /// Gets or Sets SupportedRpcRequests
        /// </summary>
        [DataMember(Name = "supported_rpc_requests", EmitDefaultValue = false)]
        public List<string> SupportedRpcRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemInfoResponseData {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  SupportedParameterTypes: ").Append(SupportedParameterTypes).Append("\n");
            sb.Append("  SupportedRpcRequests: ").Append(SupportedRpcRequests).Append("\n");
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
            return this.Equals(input as SystemInfoResponseData);
        }

        /// <summary>
        /// Returns true if SystemInfoResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfoResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.SupportedParameterTypes == input.SupportedParameterTypes ||
                    this.SupportedParameterTypes != null &&
                    input.SupportedParameterTypes != null &&
                    this.SupportedParameterTypes.SequenceEqual(input.SupportedParameterTypes)
                ) && 
                (
                    this.SupportedRpcRequests == input.SupportedRpcRequests ||
                    this.SupportedRpcRequests != null &&
                    input.SupportedRpcRequests != null &&
                    this.SupportedRpcRequests.SequenceEqual(input.SupportedRpcRequests)
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
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                }
                if (this.ApiVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ApiVersion.GetHashCode();
                }
                if (this.SupportedParameterTypes != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedParameterTypes.GetHashCode();
                }
                if (this.SupportedRpcRequests != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedRpcRequests.GetHashCode();
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
