// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.VoiceServices
{
    internal class VoiceServicesTestLineOperationSource : IOperationSource<VoiceServicesTestLineResource>
    {
        private readonly ArmClient _client;

        internal VoiceServicesTestLineOperationSource(ArmClient client)
        {
            _client = client;
        }

        VoiceServicesTestLineResource IOperationSource<VoiceServicesTestLineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VoiceServicesTestLineData>(response.Content);
            return new VoiceServicesTestLineResource(_client, data);
        }

        async ValueTask<VoiceServicesTestLineResource> IOperationSource<VoiceServicesTestLineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VoiceServicesTestLineData>(response.Content);
            return await Task.FromResult(new VoiceServicesTestLineResource(_client, data)).ConfigureAwait(false);
        }
    }
}
