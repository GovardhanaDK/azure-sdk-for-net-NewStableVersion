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
    internal class ManagedInstanceEncryptionProtectorOperationSource : IOperationSource<ManagedInstanceEncryptionProtectorResource>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceEncryptionProtectorOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceEncryptionProtectorResource IOperationSource<ManagedInstanceEncryptionProtectorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedInstanceEncryptionProtectorData>(response.Content);
            return new ManagedInstanceEncryptionProtectorResource(_client, data);
        }

        async ValueTask<ManagedInstanceEncryptionProtectorResource> IOperationSource<ManagedInstanceEncryptionProtectorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedInstanceEncryptionProtectorData>(response.Content);
            return await Task.FromResult(new ManagedInstanceEncryptionProtectorResource(_client, data)).ConfigureAwait(false);
        }
    }
}
