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
    internal class PrivateDnsZoneGroupOperationSource : IOperationSource<PrivateDnsZoneGroupResource>
    {
        private readonly ArmClient _client;

        internal PrivateDnsZoneGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateDnsZoneGroupResource IOperationSource<PrivateDnsZoneGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PrivateDnsZoneGroupData>(response.Content);
            return new PrivateDnsZoneGroupResource(_client, data);
        }

        async ValueTask<PrivateDnsZoneGroupResource> IOperationSource<PrivateDnsZoneGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PrivateDnsZoneGroupData>(response.Content);
            return await Task.FromResult(new PrivateDnsZoneGroupResource(_client, data)).ConfigureAwait(false);
        }
    }
}
