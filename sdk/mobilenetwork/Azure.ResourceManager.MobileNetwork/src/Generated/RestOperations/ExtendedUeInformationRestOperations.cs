// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.MobileNetwork
{
    internal partial class ExtendedUeInformationRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ExtendedUeInformationRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ExtendedUeInformationRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string ueId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/ues/", false);
            uri.AppendPath(ueId, true);
            uri.AppendPath("/extendedInformation/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string ueId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/ues/", false);
            uri.AppendPath(ueId, true);
            uri.AppendPath("/extendedInformation/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets extended information about the specified UE from the packet core. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="ueId"> IMSI of a UE. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="ueId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="ueId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExtendedUEInfoData>> GetAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string ueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(ueId, nameof(ueId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, ueId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtendedUEInfoData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ExtendedUEInfoData.DeserializeExtendedUEInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExtendedUEInfoData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets extended information about the specified UE from the packet core. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="ueId"> IMSI of a UE. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="ueId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="ueId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExtendedUEInfoData> Get(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string ueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(ueId, nameof(ueId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, ueId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtendedUEInfoData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ExtendedUEInfoData.DeserializeExtendedUEInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExtendedUEInfoData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
