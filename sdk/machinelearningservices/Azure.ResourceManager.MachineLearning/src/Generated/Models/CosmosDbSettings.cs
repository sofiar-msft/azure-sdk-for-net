// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The CosmosDbSettings.
    /// Serialized Name: CosmosDbSettings
    /// </summary>
    internal partial class CosmosDbSettings
    {
        /// <summary> Initializes a new instance of CosmosDbSettings. </summary>
        public CosmosDbSettings()
        {
        }

        /// <summary> Initializes a new instance of CosmosDbSettings. </summary>
        /// <param name="collectionsThroughput">
        /// The throughput of the collections in cosmosdb database
        /// Serialized Name: CosmosDbSettings.collectionsThroughput
        /// </param>
        internal CosmosDbSettings(int? collectionsThroughput)
        {
            CollectionsThroughput = collectionsThroughput;
        }

        /// <summary>
        /// The throughput of the collections in cosmosdb database
        /// Serialized Name: CosmosDbSettings.collectionsThroughput
        /// </summary>
        public int? CollectionsThroughput { get; set; }
    }
}
