// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Support
{
    internal class SupportTicketNoSubCommunicationOperationSource : IOperationSource<SupportTicketNoSubCommunicationResource>
    {
        private readonly ArmClient _client;

        internal SupportTicketNoSubCommunicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        SupportTicketNoSubCommunicationResource IOperationSource<SupportTicketNoSubCommunicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SupportTicketCommunicationData>(response.Content);
            return new SupportTicketNoSubCommunicationResource(_client, data);
        }

        async ValueTask<SupportTicketNoSubCommunicationResource> IOperationSource<SupportTicketNoSubCommunicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SupportTicketCommunicationData>(response.Content);
            return await Task.FromResult(new SupportTicketNoSubCommunicationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
