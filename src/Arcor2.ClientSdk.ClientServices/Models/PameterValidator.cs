﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using Arcor2.ClientSdk.ClientServices.Enums;
using Arcor2.ClientSdk.Communication.OpenApi.Models;
using Newtonsoft.Json;

namespace Arcor2.ClientSdk.ClientServices.Models {

    /// <summary>
    /// Represents parameter validation rules included in <see cref="ParameterMeta.Extra"/> property.
    /// </summary>
    public abstract class ParameterValidator {
        /// <summary>
        /// Validates the string representation of the parameter value.
        /// </summary>
        public abstract bool Validate(string value);

        /// <summary>
        /// Converts the validator into JSON as a valid <see cref="ParameterMeta.Extra"/> value.
        /// </summary>
        public abstract string ToJson();

        /// <summary>
        /// The type of parameter validation rule.
        /// </summary>
        public abstract ParameterValidationType Type { get; }
    }

    /// <summary>
    /// Validates if parameter value is within a given range.
    /// </summary>
    public class RangeParameterValidator : ParameterValidator {
        /// <summary>
        /// The minimum value of the parameter.
        /// </summary>
        [DataMember(Name = "minimum")]
        [JsonProperty("minimum")]
        public decimal Minimum { get; set; }

        /// <summary>
        /// The maximum value of the parameter.
        /// </summary>
        [DataMember(Name = "minimum")]
        [JsonProperty("maximum")]
        public decimal Maximum { get; set; }

        /// <inheritdoc cref="ParameterValidator"/>
        public override string ToJson() {
            return JsonConvert.SerializeObject(this);
        }

        /// <inheritdoc cref="ParameterValidator"/>
        public override ParameterValidationType Type { get; } = ParameterValidationType.Range;

        /// <summary>
        /// Validates if parameter value is within a given range.
        /// </summary>
        /// <param name="value">The string representation of the value.</param>
        /// <returns><c>true</c> if yes, <c>false</c> if no.</returns>
        public override bool Validate(string value) {
            var dValue = decimal.Parse(value, CultureInfo.InvariantCulture);
            return dValue <= Maximum && dValue >= Minimum;
        }

        /// <summary>
        /// Validates if parameter value is within a given range.
        /// </summary>
        /// <param name="dValue">The value.</param>
        /// <returns><c>true</c> if yes, <c>false</c> if no.</returns>
        public bool Validate(decimal dValue) {
            return dValue <= Maximum && dValue >= Minimum;
        }

        /// <summary>
        /// Validates if parameter value is within a given range.
        /// </summary>
        /// <param name="dValue">The value.</param>
        /// <returns><c>true</c> if yes, <c>false</c> if no.</returns>
        public bool Validate(double dValue) {
            return (decimal) dValue <= Maximum && (decimal) dValue >= Minimum;
        }

        /// <summary>
        /// Validates if parameter value is within a given range.
        /// </summary>
        /// <param name="dValue">The value.</param>
        /// <returns><c>true</c> if yes, <c>false</c> if no.</returns>
        public bool Validate(int dValue) {
            return dValue <= Maximum && dValue >= Minimum;
        }
    }

    /// <summary>
    /// Validates if parameter value is within the allowed values.
    /// </summary>
    public class ValuesParameterValidator : ParameterValidator {
        /// <summary>
        /// The allowed parameter values.
        /// </summary>
        [DataMember(Name = "allowed_values")]
        [JsonProperty("allowed_values")]
        public IList<string> AllowedValues { get; set; } = null!;

        /// <inheritdoc cref="ParameterValidator"/>
        public override ParameterValidationType Type { get;  } = ParameterValidationType.Values;

        /// <inheritdoc cref="ParameterValidator"/>
        public override string ToJson() {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Validates if parameter value is within the allowed values using the <see cref="StringComparison.InvariantCulture"/> comparer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if yes, <c>false</c> if no.</returns>
        public override bool Validate(string value) {
            return AllowedValues.Any(v => v.Equals(value, StringComparison.InvariantCulture));
        }

        /// <summary>
        /// Validates if parameter value is within the allowed values.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="comparisonType">The string comparision type.</param>
        /// <returns><c>true</c> if yes, <c>false</c> if no.</returns>
        public bool Validate(string value, StringComparison comparisonType) {
            return AllowedValues.Any(v => v.Equals(value, comparisonType));
        }
    }
}
