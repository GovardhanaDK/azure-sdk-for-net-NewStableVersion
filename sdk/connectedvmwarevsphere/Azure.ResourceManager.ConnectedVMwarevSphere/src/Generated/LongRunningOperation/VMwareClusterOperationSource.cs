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
    internal class VMwareClusterOperationSource : IOperationSource<VMwareClusterResource>
    {
        private readonly ArmClient _client;

        internal VMwareClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareClusterResource IOperationSource<VMwareClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VMwareClusterData>(response.Content);
            return new VMwareClusterResource(_client, data);
        }

        async ValueTask<VMwareClusterResource> IOperationSource<VMwareClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VMwareClusterData>(response.Content);
            return await Task.FromResult(new VMwareClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
