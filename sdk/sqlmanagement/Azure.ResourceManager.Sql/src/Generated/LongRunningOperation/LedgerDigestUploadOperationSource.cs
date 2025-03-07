// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class LedgerDigestUploadOperationSource : IOperationSource<LedgerDigestUploadResource>
    {
        private readonly ArmClient _client;

        internal LedgerDigestUploadOperationSource(ArmClient client)
        {
            _client = client;
        }

        LedgerDigestUploadResource IOperationSource<LedgerDigestUploadResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<LedgerDigestUploadData>(response.Content);
            return new LedgerDigestUploadResource(_client, data);
        }

        async ValueTask<LedgerDigestUploadResource> IOperationSource<LedgerDigestUploadResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<LedgerDigestUploadData>(response.Content);
            return await Task.FromResult(new LedgerDigestUploadResource(_client, data)).ConfigureAwait(false);
        }
    }
}
