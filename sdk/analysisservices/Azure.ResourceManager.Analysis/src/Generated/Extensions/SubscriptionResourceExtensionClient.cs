// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Analysis.Models;

namespace Azure.ResourceManager.Analysis
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _analysisServerServersClientDiagnostics;
        private ServersRestOperations _analysisServerServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AnalysisServerServersClientDiagnostics => _analysisServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Analysis", AnalysisServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations AnalysisServerServersRestClient => _analysisServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AnalysisServerResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AnalysisServerResource> GetAnalysisServersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AnalysisServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AnalysisServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAnalysisServers");
                scope.Start();
                try
                {
                    var response = await AnalysisServerServersRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.AnalysisResources.Select(value => new AnalysisServerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AnalysisServerResource> GetAnalysisServers(CancellationToken cancellationToken = default)
        {
            Page<AnalysisServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AnalysisServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAnalysisServers");
                scope.Start();
                try
                {
                    var response = AnalysisServerServersRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.AnalysisResources.Select(value => new AnalysisServerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus
        /// Operation Id: Servers_ListSkusForNew
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AnalysisResourceSku> GetEligibleSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AnalysisResourceSku>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AnalysisServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetEligibleSkus");
                scope.Start();
                try
                {
                    var response = await AnalysisServerServersRestClient.ListSkusForNewAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus
        /// Operation Id: Servers_ListSkusForNew
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AnalysisResourceSku> GetEligibleSkus(CancellationToken cancellationToken = default)
        {
            Page<AnalysisResourceSku> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AnalysisServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetEligibleSkus");
                scope.Start();
                try
                {
                    var response = AnalysisServerServersRestClient.ListSkusForNew(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability
        /// Operation Id: Servers_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalysisServerNameAvailabilityResult>> CheckAnalysisServerNameAvailabilityAsync(AzureLocation location, AnalysisServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = AnalysisServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckAnalysisServerNameAvailability");
            scope.Start();
            try
            {
                var response = await AnalysisServerServersRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability
        /// Operation Id: Servers_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalysisServerNameAvailabilityResult> CheckAnalysisServerNameAvailability(AzureLocation location, AnalysisServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = AnalysisServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckAnalysisServerNameAvailability");
            scope.Start();
            try
            {
                var response = AnalysisServerServersRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
