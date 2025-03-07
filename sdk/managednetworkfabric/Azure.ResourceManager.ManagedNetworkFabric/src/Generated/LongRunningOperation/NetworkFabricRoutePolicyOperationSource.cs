// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricRoutePolicyOperationSource : IOperationSource<NetworkFabricRoutePolicyResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricRoutePolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricRoutePolicyResource IOperationSource<NetworkFabricRoutePolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFabricRoutePolicyData>(response.Content);
            return new NetworkFabricRoutePolicyResource(_client, data);
        }

        async ValueTask<NetworkFabricRoutePolicyResource> IOperationSource<NetworkFabricRoutePolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFabricRoutePolicyData>(response.Content);
            return await Task.FromResult(new NetworkFabricRoutePolicyResource(_client, data)).ConfigureAwait(false);
        }
    }
}
