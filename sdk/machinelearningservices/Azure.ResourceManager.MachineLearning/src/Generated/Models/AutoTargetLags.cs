// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The AutoTargetLags.
    /// Serialized Name: AutoTargetLags
    /// </summary>
    public partial class AutoTargetLags : TargetLags
    {
        /// <summary> Initializes a new instance of AutoTargetLags. </summary>
        public AutoTargetLags()
        {
            Mode = TargetLagsMode.Auto;
        }

        /// <summary> Initializes a new instance of AutoTargetLags. </summary>
        /// <param name="mode">
        /// [Required] Set target lags mode - Auto/Custom
        /// Serialized Name: TargetLags.mode
        /// </param>
        internal AutoTargetLags(TargetLagsMode mode) : base(mode)
        {
            Mode = mode;
        }
    }
}
