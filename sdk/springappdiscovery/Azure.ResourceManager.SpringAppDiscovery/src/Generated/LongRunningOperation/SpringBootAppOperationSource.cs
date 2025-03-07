// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery
{
    internal class SpringBootAppOperationSource : IOperationSource<SpringBootAppResource>
    {
        private readonly ArmClient _client;

        internal SpringBootAppOperationSource(ArmClient client)
        {
            _client = client;
        }

        SpringBootAppResource IOperationSource<SpringBootAppResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SpringBootAppData>(response.Content);
            return new SpringBootAppResource(_client, data);
        }

        async ValueTask<SpringBootAppResource> IOperationSource<SpringBootAppResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SpringBootAppData>(response.Content);
            return await Task.FromResult(new SpringBootAppResource(_client, data)).ConfigureAwait(false);
        }
    }
}
