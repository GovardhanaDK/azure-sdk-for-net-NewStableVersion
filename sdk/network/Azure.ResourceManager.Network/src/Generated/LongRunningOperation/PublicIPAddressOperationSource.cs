// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class PublicIPAddressOperationSource : IOperationSource<PublicIPAddressResource>
    {
        private readonly ArmClient _client;

        internal PublicIPAddressOperationSource(ArmClient client)
        {
            _client = client;
        }

        PublicIPAddressResource IOperationSource<PublicIPAddressResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PublicIPAddressData>(response.Content);
            return new PublicIPAddressResource(_client, data);
        }

        async ValueTask<PublicIPAddressResource> IOperationSource<PublicIPAddressResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PublicIPAddressData>(response.Content);
            return await Task.FromResult(new PublicIPAddressResource(_client, data)).ConfigureAwait(false);
        }
    }
}
