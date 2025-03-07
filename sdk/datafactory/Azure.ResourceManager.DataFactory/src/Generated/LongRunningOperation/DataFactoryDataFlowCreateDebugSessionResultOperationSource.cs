// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal class DataFactoryDataFlowCreateDebugSessionResultOperationSource : IOperationSource<DataFactoryDataFlowCreateDebugSessionResult>
    {
        DataFactoryDataFlowCreateDebugSessionResult IOperationSource<DataFactoryDataFlowCreateDebugSessionResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return DataFactoryDataFlowCreateDebugSessionResult.DeserializeDataFactoryDataFlowCreateDebugSessionResult(document.RootElement);
        }

        async ValueTask<DataFactoryDataFlowCreateDebugSessionResult> IOperationSource<DataFactoryDataFlowCreateDebugSessionResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return DataFactoryDataFlowCreateDebugSessionResult.DeserializeDataFactoryDataFlowCreateDebugSessionResult(document.RootElement);
        }
    }
}
