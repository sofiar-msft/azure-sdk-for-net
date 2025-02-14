// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Intended usage of the cluster
    /// Serialized Name: ClusterPurpose
    /// </summary>
    public readonly partial struct MachineLearningClusterPurpose : IEquatable<MachineLearningClusterPurpose>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningClusterPurpose"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningClusterPurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FastProdValue = "FastProd";
        private const string DenseProdValue = "DenseProd";
        private const string DevTestValue = "DevTest";

        /// <summary>
        /// FastProd
        /// Serialized Name: ClusterPurpose.FastProd
        /// </summary>
        public static MachineLearningClusterPurpose FastProd { get; } = new MachineLearningClusterPurpose(FastProdValue);
        /// <summary>
        /// DenseProd
        /// Serialized Name: ClusterPurpose.DenseProd
        /// </summary>
        public static MachineLearningClusterPurpose DenseProd { get; } = new MachineLearningClusterPurpose(DenseProdValue);
        /// <summary>
        /// DevTest
        /// Serialized Name: ClusterPurpose.DevTest
        /// </summary>
        public static MachineLearningClusterPurpose DevTest { get; } = new MachineLearningClusterPurpose(DevTestValue);
        /// <summary> Determines if two <see cref="MachineLearningClusterPurpose"/> values are the same. </summary>
        public static bool operator ==(MachineLearningClusterPurpose left, MachineLearningClusterPurpose right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningClusterPurpose"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningClusterPurpose left, MachineLearningClusterPurpose right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningClusterPurpose"/>. </summary>
        public static implicit operator MachineLearningClusterPurpose(string value) => new MachineLearningClusterPurpose(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningClusterPurpose other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningClusterPurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
