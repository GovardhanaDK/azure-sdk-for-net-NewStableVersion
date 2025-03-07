// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter
{
    internal class SecurityCenterApiCollectionOperationSource : IOperationSource<SecurityCenterApiCollectionResource>
    {
        private readonly ArmClient _client;

        internal SecurityCenterApiCollectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SecurityCenterApiCollectionResource IOperationSource<SecurityCenterApiCollectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SecurityCenterApiCollectionData>(response.Content);
            return new SecurityCenterApiCollectionResource(_client, data);
        }

        async ValueTask<SecurityCenterApiCollectionResource> IOperationSource<SecurityCenterApiCollectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SecurityCenterApiCollectionData>(response.Content);
            return await Task.FromResult(new SecurityCenterApiCollectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
