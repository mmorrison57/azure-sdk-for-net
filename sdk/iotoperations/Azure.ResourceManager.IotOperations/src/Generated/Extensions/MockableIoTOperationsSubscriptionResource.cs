// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.IoTOperations.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableIoTOperationsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _instanceResourceInstanceClientDiagnostics;
        private InstanceRestOperations _instanceResourceInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableIoTOperationsSubscriptionResource"/> class for mocking. </summary>
        protected MockableIoTOperationsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableIoTOperationsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableIoTOperationsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics InstanceResourceInstanceClientDiagnostics => _instanceResourceInstanceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IoTOperations", InstanceResource.ResourceType.Namespace, Diagnostics);
        private InstanceRestOperations InstanceResourceInstanceRestClient => _instanceResourceInstanceRestClient ??= new InstanceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(InstanceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTOperations/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InstanceResource> GetInstanceResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => InstanceResourceInstanceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => InstanceResourceInstanceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new InstanceResource(Client, InstanceResourceData.DeserializeInstanceResourceData(e)), InstanceResourceInstanceClientDiagnostics, Pipeline, "MockableIoTOperationsSubscriptionResource.GetInstanceResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTOperations/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InstanceResource> GetInstanceResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => InstanceResourceInstanceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => InstanceResourceInstanceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new InstanceResource(Client, InstanceResourceData.DeserializeInstanceResourceData(e)), InstanceResourceInstanceClientDiagnostics, Pipeline, "MockableIoTOperationsSubscriptionResource.GetInstanceResources", "value", "nextLink", cancellationToken);
        }
    }
}
