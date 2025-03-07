// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm
{
    internal class ScVmmGuestAgentOperationSource : IOperationSource<ScVmmGuestAgentResource>
    {
        private readonly ArmClient _client;

        internal ScVmmGuestAgentOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScVmmGuestAgentResource IOperationSource<ScVmmGuestAgentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ScVmmGuestAgentData>(response.Content);
            return new ScVmmGuestAgentResource(_client, data);
        }

        async ValueTask<ScVmmGuestAgentResource> IOperationSource<ScVmmGuestAgentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ScVmmGuestAgentData>(response.Content);
            return await Task.FromResult(new ScVmmGuestAgentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
