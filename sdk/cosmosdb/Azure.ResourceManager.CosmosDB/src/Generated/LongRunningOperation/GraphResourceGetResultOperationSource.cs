// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class GraphResourceGetResultOperationSource : IOperationSource<GraphResourceGetResultResource>
    {
        private readonly ArmClient _client;

        internal GraphResourceGetResultOperationSource(ArmClient client)
        {
            _client = client;
        }

        GraphResourceGetResultResource IOperationSource<GraphResourceGetResultResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GraphResourceGetResultData>(response.Content);
            return new GraphResourceGetResultResource(_client, data);
        }

        async ValueTask<GraphResourceGetResultResource> IOperationSource<GraphResourceGetResultResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GraphResourceGetResultData>(response.Content);
            return await Task.FromResult(new GraphResourceGetResultResource(_client, data)).ConfigureAwait(false);
        }
    }
}
