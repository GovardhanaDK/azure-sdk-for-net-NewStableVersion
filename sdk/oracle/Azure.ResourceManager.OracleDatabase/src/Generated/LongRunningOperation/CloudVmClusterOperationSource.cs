// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase
{
    internal class CloudVmClusterOperationSource : IOperationSource<CloudVmClusterResource>
    {
        private readonly ArmClient _client;

        internal CloudVmClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        CloudVmClusterResource IOperationSource<CloudVmClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CloudVmClusterData>(response.Content);
            return new CloudVmClusterResource(_client, data);
        }

        async ValueTask<CloudVmClusterResource> IOperationSource<CloudVmClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CloudVmClusterData>(response.Content);
            return await Task.FromResult(new CloudVmClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
