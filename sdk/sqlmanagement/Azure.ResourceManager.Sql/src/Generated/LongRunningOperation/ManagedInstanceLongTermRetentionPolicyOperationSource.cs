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
    internal class ManagedInstanceLongTermRetentionPolicyOperationSource : IOperationSource<ManagedInstanceLongTermRetentionPolicyResource>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceLongTermRetentionPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceLongTermRetentionPolicyResource IOperationSource<ManagedInstanceLongTermRetentionPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedInstanceLongTermRetentionPolicyData>(response.Content);
            return new ManagedInstanceLongTermRetentionPolicyResource(_client, data);
        }

        async ValueTask<ManagedInstanceLongTermRetentionPolicyResource> IOperationSource<ManagedInstanceLongTermRetentionPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedInstanceLongTermRetentionPolicyData>(response.Content);
            return await Task.FromResult(new ManagedInstanceLongTermRetentionPolicyResource(_client, data)).ConfigureAwait(false);
        }
    }
}
