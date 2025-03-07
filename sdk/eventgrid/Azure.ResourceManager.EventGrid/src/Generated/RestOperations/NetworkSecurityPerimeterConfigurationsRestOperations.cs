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
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    internal partial class NetworkSecurityPerimeterConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of NetworkSecurityPerimeterConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public NetworkSecurityPerimeterConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/", false);
            uri.AppendPath(resourceType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(perimeterGuid, true);
            uri.AppendPath(".", false);
            uri.AppendPath(associationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName)
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
            uri.AppendPath("/providers/Microsoft.EventGrid/", false);
            uri.AppendPath(resourceType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(perimeterGuid, true);
            uri.AppendPath(".", false);
            uri.AppendPath(associationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a specific network security perimeter configuration with a topic or domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="resourceType"> The type of the resource. This can be either \'topics\', or \'domains\'. </param>
        /// <param name="resourceName"> The name of the resource (namely, either, the topic name or domain name). </param>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkSecurityPerimeterConfigurationData>> GetAsync(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(perimeterGuid, nameof(perimeterGuid));
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceType, resourceName, perimeterGuid, associationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkSecurityPerimeterConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a specific network security perimeter configuration with a topic or domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="resourceType"> The type of the resource. This can be either \'topics\', or \'domains\'. </param>
        /// <param name="resourceName"> The name of the resource (namely, either, the topic name or domain name). </param>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkSecurityPerimeterConfigurationData> Get(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(perimeterGuid, nameof(perimeterGuid));
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceType, resourceName, perimeterGuid, associationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkSecurityPerimeterConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateReconcileRequestUri(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/", false);
            uri.AppendPath(resourceType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(perimeterGuid, true);
            uri.AppendPath(".", false);
            uri.AppendPath(associationName, true);
            uri.AppendPath("/reconcile", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateReconcileRequest(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/", false);
            uri.AppendPath(resourceType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(perimeterGuid, true);
            uri.AppendPath(".", false);
            uri.AppendPath(associationName, true);
            uri.AppendPath("/reconcile", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Reconcile a specific network security perimeter configuration for a given network security perimeter association with a topic or domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="resourceType"> The type of the resource. This can be either \'topics\' or \'domains\'. </param>
        /// <param name="resourceName"> The name of the resource (namely, either, the topic name or domain name). </param>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ReconcileAsync(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(perimeterGuid, nameof(perimeterGuid));
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var message = CreateReconcileRequest(subscriptionId, resourceGroupName, resourceType, resourceName, perimeterGuid, associationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reconcile a specific network security perimeter configuration for a given network security perimeter association with a topic or domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="resourceType"> The type of the resource. This can be either \'topics\' or \'domains\'. </param>
        /// <param name="resourceName"> The name of the resource (namely, either, the topic name or domain name). </param>
        /// <param name="perimeterGuid"> Unique identifier for perimeter. </param>
        /// <param name="associationName"> Association name to association network security perimeter resource to profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="perimeterGuid"/> or <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Reconcile(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, string perimeterGuid, string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(perimeterGuid, nameof(perimeterGuid));
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var message = CreateReconcileRequest(subscriptionId, resourceGroupName, resourceType, resourceName, perimeterGuid, associationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/", false);
            uri.AppendPath(resourceType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName)
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
            uri.AppendPath("/providers/Microsoft.EventGrid/", false);
            uri.AppendPath(resourceType.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all network security perimeter configurations associated with a topic or domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="resourceType"> The type of the resource. This can be either \'topics\' or \'domains\'. </param>
        /// <param name="resourceName"> The name of the resource (namely, either, the topic name or domain name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkSecurityPerimeterConfigurationList>> ListAsync(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceType, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = NetworkSecurityPerimeterConfigurationList.DeserializeNetworkSecurityPerimeterConfigurationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all network security perimeter configurations associated with a topic or domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="resourceType"> The type of the resource. This can be either \'topics\' or \'domains\'. </param>
        /// <param name="resourceName"> The name of the resource (namely, either, the topic name or domain name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkSecurityPerimeterConfigurationList> List(string subscriptionId, string resourceGroupName, NetworkSecurityPerimeterResourceType resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceType, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = NetworkSecurityPerimeterConfigurationList.DeserializeNetworkSecurityPerimeterConfigurationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
