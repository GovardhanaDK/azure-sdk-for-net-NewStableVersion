// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp
{
    internal class SelfHelpSolutionOperationSource : IOperationSource<SelfHelpSolutionResource>
    {
        private readonly ArmClient _client;

        internal SelfHelpSolutionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SelfHelpSolutionResource IOperationSource<SelfHelpSolutionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SelfHelpSolutionData>(response.Content);
            return new SelfHelpSolutionResource(_client, data);
        }

        async ValueTask<SelfHelpSolutionResource> IOperationSource<SelfHelpSolutionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SelfHelpSolutionData>(response.Content);
            return await Task.FromResult(new SelfHelpSolutionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
