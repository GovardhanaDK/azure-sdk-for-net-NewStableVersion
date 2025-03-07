// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Reservations
{
    internal class ReservationDetailOperationSource : IOperationSource<ReservationDetailResource>
    {
        private readonly ArmClient _client;

        internal ReservationDetailOperationSource(ArmClient client)
        {
            _client = client;
        }

        ReservationDetailResource IOperationSource<ReservationDetailResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ReservationDetailData>(response.Content);
            return new ReservationDetailResource(_client, data);
        }

        async ValueTask<ReservationDetailResource> IOperationSource<ReservationDetailResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ReservationDetailData>(response.Content);
            return await Task.FromResult(new ReservationDetailResource(_client, data)).ConfigureAwait(false);
        }
    }
}
