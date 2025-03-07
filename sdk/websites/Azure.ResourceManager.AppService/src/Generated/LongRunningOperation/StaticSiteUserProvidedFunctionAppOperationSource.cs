// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class StaticSiteUserProvidedFunctionAppOperationSource : IOperationSource<StaticSiteUserProvidedFunctionAppResource>
    {
        private readonly ArmClient _client;

        internal StaticSiteUserProvidedFunctionAppOperationSource(ArmClient client)
        {
            _client = client;
        }

        StaticSiteUserProvidedFunctionAppResource IOperationSource<StaticSiteUserProvidedFunctionAppResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StaticSiteUserProvidedFunctionAppData>(response.Content);
            return new StaticSiteUserProvidedFunctionAppResource(_client, data);
        }

        async ValueTask<StaticSiteUserProvidedFunctionAppResource> IOperationSource<StaticSiteUserProvidedFunctionAppResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StaticSiteUserProvidedFunctionAppData>(response.Content);
            return await Task.FromResult(new StaticSiteUserProvidedFunctionAppResource(_client, data)).ConfigureAwait(false);
        }
    }
}
