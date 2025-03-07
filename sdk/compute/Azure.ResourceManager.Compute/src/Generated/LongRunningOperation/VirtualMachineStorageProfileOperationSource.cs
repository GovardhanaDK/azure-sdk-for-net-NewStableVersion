// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal class VirtualMachineStorageProfileOperationSource : IOperationSource<VirtualMachineStorageProfile>
    {
        VirtualMachineStorageProfile IOperationSource<VirtualMachineStorageProfile>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return VirtualMachineStorageProfile.DeserializeVirtualMachineStorageProfile(document.RootElement);
        }

        async ValueTask<VirtualMachineStorageProfile> IOperationSource<VirtualMachineStorageProfile>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return VirtualMachineStorageProfile.DeserializeVirtualMachineStorageProfile(document.RootElement);
        }
    }
}
