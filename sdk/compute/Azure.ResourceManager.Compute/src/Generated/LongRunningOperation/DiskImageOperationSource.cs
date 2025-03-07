// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    internal class DiskImageOperationSource : IOperationSource<DiskImageResource>
    {
        private readonly ArmClient _client;

        internal DiskImageOperationSource(ArmClient client)
        {
            _client = client;
        }

        DiskImageResource IOperationSource<DiskImageResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DiskImageData>(response.Content);
            return new DiskImageResource(_client, data);
        }

        async ValueTask<DiskImageResource> IOperationSource<DiskImageResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DiskImageData>(response.Content);
            return await Task.FromResult(new DiskImageResource(_client, data)).ConfigureAwait(false);
        }
    }
}
