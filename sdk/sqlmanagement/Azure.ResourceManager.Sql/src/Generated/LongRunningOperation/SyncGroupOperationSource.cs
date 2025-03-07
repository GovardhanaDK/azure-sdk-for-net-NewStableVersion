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
    internal class SyncGroupOperationSource : IOperationSource<SyncGroupResource>
    {
        private readonly ArmClient _client;

        internal SyncGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        SyncGroupResource IOperationSource<SyncGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SyncGroupData>(response.Content);
            return new SyncGroupResource(_client, data);
        }

        async ValueTask<SyncGroupResource> IOperationSource<SyncGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SyncGroupData>(response.Content);
            return await Task.FromResult(new SyncGroupResource(_client, data)).ConfigureAwait(false);
        }
    }
}
