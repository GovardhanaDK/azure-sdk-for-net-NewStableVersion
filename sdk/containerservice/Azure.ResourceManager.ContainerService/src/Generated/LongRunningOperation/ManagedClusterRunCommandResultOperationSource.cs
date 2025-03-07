// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;

namespace Azure.ResourceManager.ContainerService
{
    internal class ManagedClusterRunCommandResultOperationSource : IOperationSource<ManagedClusterRunCommandResult>
    {
        ManagedClusterRunCommandResult IOperationSource<ManagedClusterRunCommandResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return ManagedClusterRunCommandResult.DeserializeManagedClusterRunCommandResult(document.RootElement);
        }

        async ValueTask<ManagedClusterRunCommandResult> IOperationSource<ManagedClusterRunCommandResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return ManagedClusterRunCommandResult.DeserializeManagedClusterRunCommandResult(document.RootElement);
        }
    }
}
