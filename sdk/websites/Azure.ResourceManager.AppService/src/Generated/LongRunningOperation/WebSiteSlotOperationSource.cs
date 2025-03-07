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
    internal class WebSiteSlotOperationSource : IOperationSource<WebSiteSlotResource>
    {
        private readonly ArmClient _client;

        internal WebSiteSlotOperationSource(ArmClient client)
        {
            _client = client;
        }

        WebSiteSlotResource IOperationSource<WebSiteSlotResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<WebSiteData>(response.Content);
            return new WebSiteSlotResource(_client, data);
        }

        async ValueTask<WebSiteSlotResource> IOperationSource<WebSiteSlotResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<WebSiteData>(response.Content);
            return await Task.FromResult(new WebSiteSlotResource(_client, data)).ConfigureAwait(false);
        }
    }
}
