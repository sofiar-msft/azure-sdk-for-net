// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Image Instance Segmentation. Instance segmentation is used to identify objects in an image at the pixel level,
    /// drawing a polygon around each object in the image.
    /// Serialized Name: ImageInstanceSegmentation
    /// </summary>
    public partial class ImageInstanceSegmentation : AutoMLVertical
    {
        /// <summary> Initializes a new instance of ImageInstanceSegmentation. </summary>
        /// <param name="trainingData">
        /// [Required] Training data input.
        /// Serialized Name: AutoMLVertical.trainingData
        /// </param>
        /// <param name="limitSettings">
        /// [Required] Limit settings for the AutoML job.
        /// Serialized Name: ImageVertical.limitSettings
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> or <paramref name="limitSettings"/> is null. </exception>
        public ImageInstanceSegmentation(MachineLearningTableJobInput trainingData, ImageLimitSettings limitSettings) : base(trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));
            Argument.AssertNotNull(limitSettings, nameof(limitSettings));

            SearchSpace = new ChangeTrackingList<ImageModelDistributionSettingsObjectDetection>();
            LimitSettings = limitSettings;
            TaskType = TaskType.ImageInstanceSegmentation;
        }

        /// <summary> Initializes a new instance of ImageInstanceSegmentation. </summary>
        /// <param name="logVerbosity">
        /// Log verbosity for the job.
        /// Serialized Name: AutoMLVertical.logVerbosity
        /// </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// Serialized Name: AutoMLVertical.targetColumnName
        /// </param>
        /// <param name="taskType">
        /// [Required] Task type for AutoMLJob.
        /// Serialized Name: AutoMLVertical.taskType
        /// </param>
        /// <param name="trainingData">
        /// [Required] Training data input.
        /// Serialized Name: AutoMLVertical.trainingData
        /// </param>
        /// <param name="primaryMetric">
        /// Primary metric to optimize for this task.
        /// Serialized Name: ImageInstanceSegmentation.primaryMetric
        /// </param>
        /// <param name="modelSettings">
        /// Settings used for training the model.
        /// Serialized Name: ImageObjectDetectionBase.modelSettings
        /// </param>
        /// <param name="searchSpace">
        /// Search space for sampling different combinations of models and their hyperparameters.
        /// Serialized Name: ImageObjectDetectionBase.searchSpace
        /// </param>
        /// <param name="limitSettings">
        /// [Required] Limit settings for the AutoML job.
        /// Serialized Name: ImageVertical.limitSettings
        /// </param>
        /// <param name="sweepSettings">
        /// Model sweeping and hyperparameter sweeping related settings.
        /// Serialized Name: ImageVertical.sweepSettings
        /// </param>
        /// <param name="validationData">
        /// Validation data inputs.
        /// Serialized Name: ImageVertical.validationData
        /// </param>
        /// <param name="validationDataSize">
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// Serialized Name: ImageVertical.validationDataSize
        /// </param>
        internal ImageInstanceSegmentation(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, InstanceSegmentationPrimaryMetric? primaryMetric, ImageModelSettingsObjectDetection modelSettings, IList<ImageModelDistributionSettingsObjectDetection> searchSpace, ImageLimitSettings limitSettings, ImageSweepSettings sweepSettings, MachineLearningTableJobInput validationData, double? validationDataSize) : base(logVerbosity, targetColumnName, taskType, trainingData)
        {
            PrimaryMetric = primaryMetric;
            ModelSettings = modelSettings;
            SearchSpace = searchSpace;
            LimitSettings = limitSettings;
            SweepSettings = sweepSettings;
            ValidationData = validationData;
            ValidationDataSize = validationDataSize;
            TaskType = taskType;
        }

        /// <summary>
        /// Primary metric to optimize for this task.
        /// Serialized Name: ImageInstanceSegmentation.primaryMetric
        /// </summary>
        public InstanceSegmentationPrimaryMetric? PrimaryMetric { get; set; }
        /// <summary>
        /// Settings used for training the model.
        /// Serialized Name: ImageObjectDetectionBase.modelSettings
        /// </summary>
        public ImageModelSettingsObjectDetection ModelSettings { get; set; }
        /// <summary>
        /// Search space for sampling different combinations of models and their hyperparameters.
        /// Serialized Name: ImageObjectDetectionBase.searchSpace
        /// </summary>
        public IList<ImageModelDistributionSettingsObjectDetection> SearchSpace { get; set; }
        /// <summary>
        /// [Required] Limit settings for the AutoML job.
        /// Serialized Name: ImageVertical.limitSettings
        /// </summary>
        public ImageLimitSettings LimitSettings { get; set; }
        /// <summary>
        /// Model sweeping and hyperparameter sweeping related settings.
        /// Serialized Name: ImageVertical.sweepSettings
        /// </summary>
        public ImageSweepSettings SweepSettings { get; set; }
        /// <summary>
        /// Validation data inputs.
        /// Serialized Name: ImageVertical.validationData
        /// </summary>
        public MachineLearningTableJobInput ValidationData { get; set; }
        /// <summary>
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// Serialized Name: ImageVertical.validationDataSize
        /// </summary>
        public double? ValidationDataSize { get; set; }
    }
}
