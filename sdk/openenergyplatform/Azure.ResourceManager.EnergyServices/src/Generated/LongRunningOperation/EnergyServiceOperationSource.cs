// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EnergyServices
{
    internal class EnergyServiceOperationSource : IOperationSource<EnergyServiceResource>
    {
        private readonly ArmClient _client;

        internal EnergyServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        EnergyServiceResource IOperationSource<EnergyServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EnergyServiceData>(response.Content);
            return new EnergyServiceResource(_client, data);
        }

        async ValueTask<EnergyServiceResource> IOperationSource<EnergyServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EnergyServiceData>(response.Content);
            return await Task.FromResult(new EnergyServiceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
