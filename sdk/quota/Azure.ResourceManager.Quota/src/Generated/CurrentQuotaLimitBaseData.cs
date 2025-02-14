// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota
{
    /// <summary> A class representing the CurrentQuotaLimitBase data model. </summary>
    public partial class CurrentQuotaLimitBaseData : ResourceData
    {
        /// <summary> Initializes a new instance of CurrentQuotaLimitBaseData. </summary>
        public CurrentQuotaLimitBaseData()
        {
        }

        /// <summary> Initializes a new instance of CurrentQuotaLimitBaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Quota properties for the specified resource, based on the API called, Quotas or Usages. </param>
        internal CurrentQuotaLimitBaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, QuotaProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Quota properties for the specified resource, based on the API called, Quotas or Usages. </summary>
        public QuotaProperties Properties { get; set; }
    }
}
