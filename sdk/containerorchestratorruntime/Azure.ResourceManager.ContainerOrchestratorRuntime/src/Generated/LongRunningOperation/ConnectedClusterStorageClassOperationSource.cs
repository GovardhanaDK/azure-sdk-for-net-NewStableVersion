// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    internal class ConnectedClusterStorageClassOperationSource : IOperationSource<ConnectedClusterStorageClassResource>
    {
        private readonly ArmClient _client;

        internal ConnectedClusterStorageClassOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConnectedClusterStorageClassResource IOperationSource<ConnectedClusterStorageClassResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ConnectedClusterStorageClassData>(response.Content);
            return new ConnectedClusterStorageClassResource(_client, data);
        }

        async ValueTask<ConnectedClusterStorageClassResource> IOperationSource<ConnectedClusterStorageClassResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ConnectedClusterStorageClassData>(response.Content);
            return await Task.FromResult(new ConnectedClusterStorageClassResource(_client, data)).ConfigureAwait(false);
        }
    }
}
