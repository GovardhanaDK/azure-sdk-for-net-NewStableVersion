// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns
{
    internal class PrivateDnsZoneOperationSource : IOperationSource<PrivateDnsZoneResource>
    {
        private readonly ArmClient _client;

        internal PrivateDnsZoneOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateDnsZoneResource IOperationSource<PrivateDnsZoneResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PrivateDnsZoneData>(response.Content);
            return new PrivateDnsZoneResource(_client, data);
        }

        async ValueTask<PrivateDnsZoneResource> IOperationSource<PrivateDnsZoneResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PrivateDnsZoneData>(response.Content);
            return await Task.FromResult(new PrivateDnsZoneResource(_client, data)).ConfigureAwait(false);
        }
    }
}
