// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Hci
{
    internal class ArcExtensionOperationSource : IOperationSource<ArcExtensionResource>
    {
        private readonly ArmClient _client;

        internal ArcExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ArcExtensionResource IOperationSource<ArcExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ArcExtensionData>(response.Content);
            return new ArcExtensionResource(_client, data);
        }

        async ValueTask<ArcExtensionResource> IOperationSource<ArcExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ArcExtensionData>(response.Content);
            return await Task.FromResult(new ArcExtensionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
