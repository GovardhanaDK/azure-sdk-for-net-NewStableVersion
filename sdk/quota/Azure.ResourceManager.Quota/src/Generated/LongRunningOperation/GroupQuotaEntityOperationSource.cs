// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Quota
{
    internal class GroupQuotaEntityOperationSource : IOperationSource<GroupQuotaEntityResource>
    {
        private readonly ArmClient _client;

        internal GroupQuotaEntityOperationSource(ArmClient client)
        {
            _client = client;
        }

        GroupQuotaEntityResource IOperationSource<GroupQuotaEntityResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GroupQuotaEntityData>(response.Content);
            return new GroupQuotaEntityResource(_client, data);
        }

        async ValueTask<GroupQuotaEntityResource> IOperationSource<GroupQuotaEntityResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GroupQuotaEntityData>(response.Content);
            return await Task.FromResult(new GroupQuotaEntityResource(_client, data)).ConfigureAwait(false);
        }
    }
}
