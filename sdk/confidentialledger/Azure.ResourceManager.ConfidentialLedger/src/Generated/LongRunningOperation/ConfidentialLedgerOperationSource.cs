// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger
{
    internal class ConfidentialLedgerOperationSource : IOperationSource<ConfidentialLedgerResource>
    {
        private readonly ArmClient _client;

        internal ConfidentialLedgerOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConfidentialLedgerResource IOperationSource<ConfidentialLedgerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ConfidentialLedgerData>(response.Content);
            return new ConfidentialLedgerResource(_client, data);
        }

        async ValueTask<ConfidentialLedgerResource> IOperationSource<ConfidentialLedgerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ConfidentialLedgerData>(response.Content);
            return await Task.FromResult(new ConfidentialLedgerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
