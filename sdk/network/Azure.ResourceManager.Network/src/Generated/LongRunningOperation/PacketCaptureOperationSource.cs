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
    internal class PacketCaptureOperationSource : IOperationSource<PacketCaptureResource>
    {
        private readonly ArmClient _client;

        internal PacketCaptureOperationSource(ArmClient client)
        {
            _client = client;
        }

        PacketCaptureResource IOperationSource<PacketCaptureResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PacketCaptureData>(response.Content);
            return new PacketCaptureResource(_client, data);
        }

        async ValueTask<PacketCaptureResource> IOperationSource<PacketCaptureResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PacketCaptureData>(response.Content);
            return await Task.FromResult(new PacketCaptureResource(_client, data)).ConfigureAwait(false);
        }
    }
}
