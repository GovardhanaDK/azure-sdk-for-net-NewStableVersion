// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class EventGridTopicOperationSource : IOperationSource<EventGridTopicResource>
    {
        private readonly ArmClient _client;

        internal EventGridTopicOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridTopicResource IOperationSource<EventGridTopicResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventGridTopicData>(response.Content);
            return new EventGridTopicResource(_client, data);
        }

        async ValueTask<EventGridTopicResource> IOperationSource<EventGridTopicResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventGridTopicData>(response.Content);
            return await Task.FromResult(new EventGridTopicResource(_client, data)).ConfigureAwait(false);
        }
    }
}
