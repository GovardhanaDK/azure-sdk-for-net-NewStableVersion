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
    internal class DevOpsOrgOperationSource : IOperationSource<DevOpsOrgResource>
    {
        private readonly ArmClient _client;

        internal DevOpsOrgOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevOpsOrgResource IOperationSource<DevOpsOrgResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevOpsOrgData>(response.Content);
            return new DevOpsOrgResource(_client, data);
        }

        async ValueTask<DevOpsOrgResource> IOperationSource<DevOpsOrgResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevOpsOrgData>(response.Content);
            return await Task.FromResult(new DevOpsOrgResource(_client, data)).ConfigureAwait(false);
        }
    }
}
