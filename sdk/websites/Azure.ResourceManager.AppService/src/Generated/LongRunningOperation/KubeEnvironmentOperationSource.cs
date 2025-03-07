// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class KubeEnvironmentOperationSource : IOperationSource<KubeEnvironmentResource>
    {
        private readonly ArmClient _client;

        internal KubeEnvironmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        KubeEnvironmentResource IOperationSource<KubeEnvironmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<KubeEnvironmentData>(response.Content);
            return new KubeEnvironmentResource(_client, data);
        }

        async ValueTask<KubeEnvironmentResource> IOperationSource<KubeEnvironmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<KubeEnvironmentData>(response.Content);
            return await Task.FromResult(new KubeEnvironmentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
