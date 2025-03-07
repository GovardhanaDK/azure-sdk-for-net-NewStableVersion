// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs
{
    internal class DevTestLabVirtualNetworkOperationSource : IOperationSource<DevTestLabVirtualNetworkResource>
    {
        private readonly ArmClient _client;

        internal DevTestLabVirtualNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevTestLabVirtualNetworkResource IOperationSource<DevTestLabVirtualNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabVirtualNetworkData>(response.Content);
            return new DevTestLabVirtualNetworkResource(_client, data);
        }

        async ValueTask<DevTestLabVirtualNetworkResource> IOperationSource<DevTestLabVirtualNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabVirtualNetworkData>(response.Content);
            return await Task.FromResult(new DevTestLabVirtualNetworkResource(_client, data)).ConfigureAwait(false);
        }
    }
}
