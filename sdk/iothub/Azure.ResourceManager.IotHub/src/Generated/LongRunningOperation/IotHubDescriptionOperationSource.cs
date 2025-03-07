// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.IotHub
{
    internal class IotHubDescriptionOperationSource : IOperationSource<IotHubDescriptionResource>
    {
        private readonly ArmClient _client;

        internal IotHubDescriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        IotHubDescriptionResource IOperationSource<IotHubDescriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<IotHubDescriptionData>(response.Content);
            return new IotHubDescriptionResource(_client, data);
        }

        async ValueTask<IotHubDescriptionResource> IOperationSource<IotHubDescriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<IotHubDescriptionData>(response.Content);
            return await Task.FromResult(new IotHubDescriptionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
