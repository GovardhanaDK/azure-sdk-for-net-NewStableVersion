// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    internal class RestorePointOperationSource : IOperationSource<RestorePointResource>
    {
        private readonly ArmClient _client;

        internal RestorePointOperationSource(ArmClient client)
        {
            _client = client;
        }

        RestorePointResource IOperationSource<RestorePointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RestorePointData>(response.Content);
            return new RestorePointResource(_client, data);
        }

        async ValueTask<RestorePointResource> IOperationSource<RestorePointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RestorePointData>(response.Content);
            return await Task.FromResult(new RestorePointResource(_client, data)).ConfigureAwait(false);
        }
    }
}
