// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Status of update workspace quota.
    /// Serialized Name: Status
    /// </summary>
    public readonly partial struct MachineLearningWorkspaceQuotaStatus : IEquatable<MachineLearningWorkspaceQuotaStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceQuotaStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningWorkspaceQuotaStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndefinedValue = "Undefined";
        private const string SuccessValue = "Success";
        private const string FailureValue = "Failure";
        private const string InvalidQuotaBelowClusterMinimumValue = "InvalidQuotaBelowClusterMinimum";
        private const string InvalidQuotaExceedsSubscriptionLimitValue = "InvalidQuotaExceedsSubscriptionLimit";
        private const string InvalidVmFamilyNameValue = "InvalidVMFamilyName";
        private const string OperationNotSupportedForSkuValue = "OperationNotSupportedForSku";
        private const string OperationNotEnabledForRegionValue = "OperationNotEnabledForRegion";

        /// <summary>
        /// Undefined
        /// Serialized Name: Status.Undefined
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus Undefined { get; } = new MachineLearningWorkspaceQuotaStatus(UndefinedValue);
        /// <summary>
        /// Success
        /// Serialized Name: Status.Success
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus Success { get; } = new MachineLearningWorkspaceQuotaStatus(SuccessValue);
        /// <summary>
        /// Failure
        /// Serialized Name: Status.Failure
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus Failure { get; } = new MachineLearningWorkspaceQuotaStatus(FailureValue);
        /// <summary>
        /// InvalidQuotaBelowClusterMinimum
        /// Serialized Name: Status.InvalidQuotaBelowClusterMinimum
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus InvalidQuotaBelowClusterMinimum { get; } = new MachineLearningWorkspaceQuotaStatus(InvalidQuotaBelowClusterMinimumValue);
        /// <summary>
        /// InvalidQuotaExceedsSubscriptionLimit
        /// Serialized Name: Status.InvalidQuotaExceedsSubscriptionLimit
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus InvalidQuotaExceedsSubscriptionLimit { get; } = new MachineLearningWorkspaceQuotaStatus(InvalidQuotaExceedsSubscriptionLimitValue);
        /// <summary>
        /// InvalidVMFamilyName
        /// Serialized Name: Status.InvalidVMFamilyName
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus InvalidVmFamilyName { get; } = new MachineLearningWorkspaceQuotaStatus(InvalidVmFamilyNameValue);
        /// <summary>
        /// OperationNotSupportedForSku
        /// Serialized Name: Status.OperationNotSupportedForSku
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus OperationNotSupportedForSku { get; } = new MachineLearningWorkspaceQuotaStatus(OperationNotSupportedForSkuValue);
        /// <summary>
        /// OperationNotEnabledForRegion
        /// Serialized Name: Status.OperationNotEnabledForRegion
        /// </summary>
        public static MachineLearningWorkspaceQuotaStatus OperationNotEnabledForRegion { get; } = new MachineLearningWorkspaceQuotaStatus(OperationNotEnabledForRegionValue);
        /// <summary> Determines if two <see cref="MachineLearningWorkspaceQuotaStatus"/> values are the same. </summary>
        public static bool operator ==(MachineLearningWorkspaceQuotaStatus left, MachineLearningWorkspaceQuotaStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningWorkspaceQuotaStatus"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningWorkspaceQuotaStatus left, MachineLearningWorkspaceQuotaStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningWorkspaceQuotaStatus"/>. </summary>
        public static implicit operator MachineLearningWorkspaceQuotaStatus(string value) => new MachineLearningWorkspaceQuotaStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningWorkspaceQuotaStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningWorkspaceQuotaStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
