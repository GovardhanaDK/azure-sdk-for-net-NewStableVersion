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
    internal class VpnSiteOperationSource : IOperationSource<VpnSiteResource>
    {
        private readonly ArmClient _client;

        internal VpnSiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        VpnSiteResource IOperationSource<VpnSiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VpnSiteData>(response.Content);
            return new VpnSiteResource(_client, data);
        }

        async ValueTask<VpnSiteResource> IOperationSource<VpnSiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VpnSiteData>(response.Content);
            return await Task.FromResult(new VpnSiteResource(_client, data)).ConfigureAwait(false);
        }
    }
}
