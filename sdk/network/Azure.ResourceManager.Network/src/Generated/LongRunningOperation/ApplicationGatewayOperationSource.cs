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
    internal class ApplicationGatewayOperationSource : IOperationSource<ApplicationGatewayResource>
    {
        private readonly ArmClient _client;

        internal ApplicationGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApplicationGatewayResource IOperationSource<ApplicationGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ApplicationGatewayData>(response.Content);
            return new ApplicationGatewayResource(_client, data);
        }

        async ValueTask<ApplicationGatewayResource> IOperationSource<ApplicationGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ApplicationGatewayData>(response.Content);
            return await Task.FromResult(new ApplicationGatewayResource(_client, data)).ConfigureAwait(false);
        }
    }
}
