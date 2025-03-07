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
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    internal partial class SearchManagementRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SearchManagementRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SearchManagementRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2025-02-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateUsageBySubscriptionSkuRequestUri(string subscriptionId, AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Search/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/usages/", false);
            uri.AppendPath(skuName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUsageBySubscriptionSkuRequest(string subscriptionId, AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Search/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/usages/", false);
            uri.AppendPath(skuName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the quota usage for a search SKU in the given subscription. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="skuName"> The unique SKU name that identifies a billable tier. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="skuName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QuotaUsageResult>> UsageBySubscriptionSkuAsync(string subscriptionId, AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var message = CreateUsageBySubscriptionSkuRequest(subscriptionId, location, skuName, searchManagementRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaUsageResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = QuotaUsageResult.DeserializeQuotaUsageResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the quota usage for a search SKU in the given subscription. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="skuName"> The unique SKU name that identifies a billable tier. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="skuName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QuotaUsageResult> UsageBySubscriptionSku(string subscriptionId, AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var message = CreateUsageBySubscriptionSkuRequest(subscriptionId, location, skuName, searchManagementRequestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QuotaUsageResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = QuotaUsageResult.DeserializeQuotaUsageResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
