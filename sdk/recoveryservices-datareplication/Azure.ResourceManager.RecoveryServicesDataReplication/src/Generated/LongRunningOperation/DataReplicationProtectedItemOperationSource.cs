// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    internal class DataReplicationProtectedItemOperationSource : IOperationSource<DataReplicationProtectedItemResource>
    {
        private readonly ArmClient _client;

        internal DataReplicationProtectedItemOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataReplicationProtectedItemResource IOperationSource<DataReplicationProtectedItemResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataReplicationProtectedItemData>(response.Content);
            return new DataReplicationProtectedItemResource(_client, data);
        }

        async ValueTask<DataReplicationProtectedItemResource> IOperationSource<DataReplicationProtectedItemResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataReplicationProtectedItemData>(response.Content);
            return await Task.FromResult(new DataReplicationProtectedItemResource(_client, data)).ConfigureAwait(false);
        }
    }
}
