// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class ResourceGroupLongTermRetentionBackupOperationSource : IOperationSource<ResourceGroupLongTermRetentionBackupResource>
    {
        private readonly ArmClient _client;

        internal ResourceGroupLongTermRetentionBackupOperationSource(ArmClient client)
        {
            _client = client;
        }

        ResourceGroupLongTermRetentionBackupResource IOperationSource<ResourceGroupLongTermRetentionBackupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<LongTermRetentionBackupData>(response.Content);
            return new ResourceGroupLongTermRetentionBackupResource(_client, data);
        }

        async ValueTask<ResourceGroupLongTermRetentionBackupResource> IOperationSource<ResourceGroupLongTermRetentionBackupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<LongTermRetentionBackupData>(response.Content);
            return await Task.FromResult(new ResourceGroupLongTermRetentionBackupResource(_client, data)).ConfigureAwait(false);
        }
    }
}
