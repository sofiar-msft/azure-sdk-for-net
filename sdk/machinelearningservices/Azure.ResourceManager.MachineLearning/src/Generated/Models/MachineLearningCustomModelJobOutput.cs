// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningCustomModelJobOutput.
    /// Serialized Name: CustomModelJobOutput
    /// </summary>
    public partial class MachineLearningCustomModelJobOutput : MachineLearningJobOutput
    {
        /// <summary> Initializes a new instance of MachineLearningCustomModelJobOutput. </summary>
        public MachineLearningCustomModelJobOutput()
        {
            JobOutputType = JobOutputType.CustomModel;
        }

        /// <summary> Initializes a new instance of MachineLearningCustomModelJobOutput. </summary>
        /// <param name="description">
        /// Description for the output.
        /// Serialized Name: JobOutput.description
        /// </param>
        /// <param name="jobOutputType">
        /// [Required] Specifies the type of job.
        /// Serialized Name: JobOutput.jobOutputType
        /// </param>
        /// <param name="mode">
        /// Output Asset Delivery Mode.
        /// Serialized Name: AssetJobOutput.mode
        /// </param>
        /// <param name="uri">
        /// Output Asset URI.
        /// Serialized Name: AssetJobOutput.uri
        /// </param>
        internal MachineLearningCustomModelJobOutput(string description, JobOutputType jobOutputType, MachineLearningOutputDeliveryMode? mode, Uri uri) : base(description, jobOutputType)
        {
            Mode = mode;
            Uri = uri;
            JobOutputType = jobOutputType;
        }

        /// <summary>
        /// Output Asset Delivery Mode.
        /// Serialized Name: AssetJobOutput.mode
        /// </summary>
        public MachineLearningOutputDeliveryMode? Mode { get; set; }
        /// <summary>
        /// Output Asset URI.
        /// Serialized Name: AssetJobOutput.uri
        /// </summary>
        public Uri Uri { get; set; }
    }
}
