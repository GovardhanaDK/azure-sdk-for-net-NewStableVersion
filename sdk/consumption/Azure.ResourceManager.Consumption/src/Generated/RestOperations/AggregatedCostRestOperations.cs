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
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    internal partial class AggregatedCostRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AggregatedCostRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AggregatedCostRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetByManagementGroupRequestUri(string managementGroupId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/aggregatedcost", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateGetByManagementGroupRequest(string managementGroupId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/aggregatedcost", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Provides the aggregate cost of a management group and all child management groups by current billing period. </summary>
        /// <param name="managementGroupId"> Azure Management Group ID. </param>
        /// <param name="filter"> May be used to filter aggregated cost by properties/usageStart (Utc time), properties/usageEnd (Utc time). The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumptionAggregatedCostResult>> GetByManagementGroupAsync(string managementGroupId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));

            using var message = CreateGetByManagementGroupRequest(managementGroupId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionAggregatedCostResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ConsumptionAggregatedCostResult.DeserializeConsumptionAggregatedCostResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Provides the aggregate cost of a management group and all child management groups by current billing period. </summary>
        /// <param name="managementGroupId"> Azure Management Group ID. </param>
        /// <param name="filter"> May be used to filter aggregated cost by properties/usageStart (Utc time), properties/usageEnd (Utc time). The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumptionAggregatedCostResult> GetByManagementGroup(string managementGroupId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));

            using var message = CreateGetByManagementGroupRequest(managementGroupId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionAggregatedCostResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ConsumptionAggregatedCostResult.DeserializeConsumptionAggregatedCostResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetForBillingPeriodByManagementGroupRequestUri(string managementGroupId, string billingPeriodName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Billing/billingPeriods/", false);
            uri.AppendPath(billingPeriodName, true);
            uri.AppendPath("/providers/Microsoft.Consumption/aggregatedCost", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetForBillingPeriodByManagementGroupRequest(string managementGroupId, string billingPeriodName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Billing/billingPeriods/", false);
            uri.AppendPath(billingPeriodName, true);
            uri.AppendPath("/providers/Microsoft.Consumption/aggregatedCost", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Provides the aggregate cost of a management group and all child management groups by specified billing period. </summary>
        /// <param name="managementGroupId"> Azure Management Group ID. </param>
        /// <param name="billingPeriodName"> Billing Period Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> or <paramref name="billingPeriodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="billingPeriodName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumptionAggregatedCostResult>> GetForBillingPeriodByManagementGroupAsync(string managementGroupId, string billingPeriodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(billingPeriodName, nameof(billingPeriodName));

            using var message = CreateGetForBillingPeriodByManagementGroupRequest(managementGroupId, billingPeriodName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionAggregatedCostResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ConsumptionAggregatedCostResult.DeserializeConsumptionAggregatedCostResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Provides the aggregate cost of a management group and all child management groups by specified billing period. </summary>
        /// <param name="managementGroupId"> Azure Management Group ID. </param>
        /// <param name="billingPeriodName"> Billing Period Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/> or <paramref name="billingPeriodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/> or <paramref name="billingPeriodName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumptionAggregatedCostResult> GetForBillingPeriodByManagementGroup(string managementGroupId, string billingPeriodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(billingPeriodName, nameof(billingPeriodName));

            using var message = CreateGetForBillingPeriodByManagementGroupRequest(managementGroupId, billingPeriodName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionAggregatedCostResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ConsumptionAggregatedCostResult.DeserializeConsumptionAggregatedCostResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
