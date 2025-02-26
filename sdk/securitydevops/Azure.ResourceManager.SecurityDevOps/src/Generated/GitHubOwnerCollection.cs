// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing a collection of <see cref="GitHubOwnerResource" /> and their operations.
    /// Each <see cref="GitHubOwnerResource" /> in the collection will belong to the same instance of <see cref="GitHubConnectorResource" />.
    /// To get a <see cref="GitHubOwnerCollection" /> instance call the GetGitHubOwners method from an instance of <see cref="GitHubConnectorResource" />.
    /// </summary>
    public partial class GitHubOwnerCollection : ArmCollection, IEnumerable<GitHubOwnerResource>, IAsyncEnumerable<GitHubOwnerResource>
    {
        private readonly ClientDiagnostics _gitHubOwnerClientDiagnostics;
        private readonly GitHubOwnerRestOperations _gitHubOwnerRestClient;

        /// <summary> Initializes a new instance of the <see cref="GitHubOwnerCollection"/> class for mocking. </summary>
        protected GitHubOwnerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GitHubOwnerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GitHubOwnerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gitHubOwnerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", GitHubOwnerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GitHubOwnerResource.ResourceType, out string gitHubOwnerApiVersion);
            _gitHubOwnerRestClient = new GitHubOwnerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gitHubOwnerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GitHubConnectorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GitHubConnectorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gitHubOwnerName"> Name of the GitHub Owner. </param>
        /// <param name="data"> Github owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubOwnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubOwnerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GitHubOwnerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gitHubOwnerName, GitHubOwnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubOwnerName, nameof(gitHubOwnerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gitHubOwnerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityDevOpsArmOperation<GitHubOwnerResource>(new GitHubOwnerOperationSource(Client), _gitHubOwnerClientDiagnostics, Pipeline, _gitHubOwnerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gitHubOwnerName"> Name of the GitHub Owner. </param>
        /// <param name="data"> Github owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubOwnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubOwnerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GitHubOwnerResource> CreateOrUpdate(WaitUntil waitUntil, string gitHubOwnerName, GitHubOwnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubOwnerName, nameof(gitHubOwnerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gitHubOwnerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, data, cancellationToken);
                var operation = new SecurityDevOpsArmOperation<GitHubOwnerResource>(new GitHubOwnerOperationSource(Client), _gitHubOwnerClientDiagnostics, Pipeline, _gitHubOwnerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubOwnerName"> Name of the GitHub Owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubOwnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubOwnerName"/> is null. </exception>
        public virtual async Task<Response<GitHubOwnerResource>> GetAsync(string gitHubOwnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubOwnerName, nameof(gitHubOwnerName));

            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerCollection.Get");
            scope.Start();
            try
            {
                var response = await _gitHubOwnerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubOwnerName"> Name of the GitHub Owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubOwnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubOwnerName"/> is null. </exception>
        public virtual Response<GitHubOwnerResource> Get(string gitHubOwnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubOwnerName, nameof(gitHubOwnerName));

            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerCollection.Get");
            scope.Start();
            try
            {
                var response = _gitHubOwnerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of monitored GitHub owners.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GitHubOwnerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GitHubOwnerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitHubOwnerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _gitHubOwnerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GitHubOwnerResource(Client, GitHubOwnerData.DeserializeGitHubOwnerData(e)), _gitHubOwnerClientDiagnostics, Pipeline, "GitHubOwnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored GitHub owners.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GitHubOwnerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GitHubOwnerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitHubOwnerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _gitHubOwnerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GitHubOwnerResource(Client, GitHubOwnerData.DeserializeGitHubOwnerData(e)), _gitHubOwnerClientDiagnostics, Pipeline, "GitHubOwnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubOwnerName"> Name of the GitHub Owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubOwnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubOwnerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gitHubOwnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubOwnerName, nameof(gitHubOwnerName));

            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _gitHubOwnerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwner_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubOwnerName"> Name of the GitHub Owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubOwnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubOwnerName"/> is null. </exception>
        public virtual Response<bool> Exists(string gitHubOwnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubOwnerName, nameof(gitHubOwnerName));

            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerCollection.Exists");
            scope.Start();
            try
            {
                var response = _gitHubOwnerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gitHubOwnerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GitHubOwnerResource> IEnumerable<GitHubOwnerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GitHubOwnerResource> IAsyncEnumerable<GitHubOwnerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
