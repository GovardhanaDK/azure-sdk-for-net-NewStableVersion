// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VMwareVirtualNetworkOperationSource : IOperationSource<VMwareVirtualNetworkResource>
    {
        private readonly ArmClient _client;

        internal VMwareVirtualNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareVirtualNetworkResource IOperationSource<VMwareVirtualNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VMwareVirtualNetworkData>(response.Content);
            return new VMwareVirtualNetworkResource(_client, data);
        }

        async ValueTask<VMwareVirtualNetworkResource> IOperationSource<VMwareVirtualNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VMwareVirtualNetworkData>(response.Content);
            return await Task.FromResult(new VMwareVirtualNetworkResource(_client, data)).ConfigureAwait(false);
        }
    }
}
