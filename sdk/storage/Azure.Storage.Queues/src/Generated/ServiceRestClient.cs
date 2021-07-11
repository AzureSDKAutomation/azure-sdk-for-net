// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Queues.Models;

namespace Azure.Storage.Queues
{
    internal partial class ServiceRestClient
    {
        private string url;
        private string version;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, queue or message that is the target of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version = "2018-03-28")
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            this.url = url;
            this.version = version;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateSetPropertiesRequest(QueueServiceProperties storageServiceProperties, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            request.Headers.Add("Content-Type", "application/xml");
            var content = new XmlWriterContent();
            content.XmlWriter.WriteObjectValue(storageServiceProperties, "StorageServiceProperties");
            request.Content = content;
            return message;
        }

        /// <summary> Sets properties for a storage account&apos;s Queue service endpoint, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="storageServiceProperties"> The StorageService properties. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageServiceProperties"/> is null. </exception>
        public async Task<ResponseWithHeaders<ServiceSetPropertiesHeaders>> SetPropertiesAsync(QueueServiceProperties storageServiceProperties, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (storageServiceProperties == null)
            {
                throw new ArgumentNullException(nameof(storageServiceProperties));
            }

            using var message = CreateSetPropertiesRequest(storageServiceProperties, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceSetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sets properties for a storage account&apos;s Queue service endpoint, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="storageServiceProperties"> The StorageService properties. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageServiceProperties"/> is null. </exception>
        public ResponseWithHeaders<ServiceSetPropertiesHeaders> SetProperties(QueueServiceProperties storageServiceProperties, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (storageServiceProperties == null)
            {
                throw new ArgumentNullException(nameof(storageServiceProperties));
            }

            using var message = CreateSetPropertiesRequest(storageServiceProperties, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceSetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPropertiesRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "properties", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> gets the properties of a storage account&apos;s Queue service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueServiceProperties, ServiceGetPropertiesHeaders>> GetPropertiesAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueueServiceProperties value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceProperties") is XElement storageServicePropertiesElement)
                        {
                            value = QueueServiceProperties.DeserializeQueueServiceProperties(storageServicePropertiesElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> gets the properties of a storage account&apos;s Queue service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueServiceProperties, ServiceGetPropertiesHeaders> GetProperties(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueueServiceProperties value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceProperties") is XElement storageServicePropertiesElement)
                        {
                            value = QueueServiceProperties.DeserializeQueueServiceProperties(storageServicePropertiesElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStatisticsRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("restype", "service", true);
            uri.AppendQuery("comp", "stats", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> Retrieves statistics related to replication for the Queue service. It is only available on the secondary location endpoint when read-access geo-redundant replication is enabled for the storage account. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueServiceStatistics, ServiceGetStatisticsHeaders>> GetStatisticsAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetStatisticsRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceGetStatisticsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueueServiceStatistics value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceStats") is XElement storageServiceStatsElement)
                        {
                            value = QueueServiceStatistics.DeserializeQueueServiceStatistics(storageServiceStatsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves statistics related to replication for the Queue service. It is only available on the secondary location endpoint when read-access geo-redundant replication is enabled for the storage account. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueServiceStatistics, ServiceGetStatisticsHeaders> GetStatistics(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetStatisticsRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceGetStatisticsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueueServiceStatistics value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("StorageServiceStats") is XElement storageServiceStatsElement)
                        {
                            value = QueueServiceStatistics.DeserializeQueueServiceStatistics(storageServiceStatsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListQueuesSegmentRequest(string prefix, string marker, int? maxresults, IEnumerable<string> include, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("comp", "list", true);
            if (prefix != null)
            {
                uri.AppendQuery("prefix", prefix, true);
            }
            if (marker != null)
            {
                uri.AppendQuery("marker", marker, true);
            }
            if (maxresults != null)
            {
                uri.AppendQuery("maxresults", maxresults.Value, true);
            }
            if (include != null)
            {
                uri.AppendQueryDelimited("include", include, ",", true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The List Queues Segment operation returns a list of the queues under the specified account. </summary>
        /// <param name="prefix"> Filters the results to return only queues whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list of queues to be returned with the next listing operation. The operation returns the NextMarker value within the response body if the listing operation did not return all queues remaining to be listed with the current page. The NextMarker value can be used as the value for the marker parameter in a subsequent call to request the next page of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of queues to return. If the request does not specify maxresults, or specifies a value greater than 5000, the server will return up to 5000 items. Note that if the listing operation crosses a partition boundary, then the service will return a continuation token for retrieving the remainder of the results. For this reason, it is possible that the service will return fewer results than specified by maxresults, or than the default of 5000. </param>
        /// <param name="include"> Include this parameter to specify that the queues&apos; metadata be returned as part of the response body. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<ListQueuesSegmentResponse, ServiceListQueuesSegmentHeaders>> ListQueuesSegmentAsync(string prefix = null, string marker = null, int? maxresults = null, IEnumerable<string> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListQueuesSegmentRequest(prefix, marker, maxresults, include, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceListQueuesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListQueuesSegmentResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListQueuesSegmentResponse.DeserializeListQueuesSegmentResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The List Queues Segment operation returns a list of the queues under the specified account. </summary>
        /// <param name="prefix"> Filters the results to return only queues whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list of queues to be returned with the next listing operation. The operation returns the NextMarker value within the response body if the listing operation did not return all queues remaining to be listed with the current page. The NextMarker value can be used as the value for the marker parameter in a subsequent call to request the next page of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of queues to return. If the request does not specify maxresults, or specifies a value greater than 5000, the server will return up to 5000 items. Note that if the listing operation crosses a partition boundary, then the service will return a continuation token for retrieving the remainder of the results. For this reason, it is possible that the service will return fewer results than specified by maxresults, or than the default of 5000. </param>
        /// <param name="include"> Include this parameter to specify that the queues&apos; metadata be returned as part of the response body. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<ListQueuesSegmentResponse, ServiceListQueuesSegmentHeaders> ListQueuesSegment(string prefix = null, string marker = null, int? maxresults = null, IEnumerable<string> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListQueuesSegmentRequest(prefix, marker, maxresults, include, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceListQueuesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListQueuesSegmentResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListQueuesSegmentResponse.DeserializeListQueuesSegmentResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListQueuesSegmentNextPageRequest(string nextLink, string prefix, string marker, int? maxresults, IEnumerable<string> include, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The List Queues Segment operation returns a list of the queues under the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="prefix"> Filters the results to return only queues whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list of queues to be returned with the next listing operation. The operation returns the NextMarker value within the response body if the listing operation did not return all queues remaining to be listed with the current page. The NextMarker value can be used as the value for the marker parameter in a subsequent call to request the next page of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of queues to return. If the request does not specify maxresults, or specifies a value greater than 5000, the server will return up to 5000 items. Note that if the listing operation crosses a partition boundary, then the service will return a continuation token for retrieving the remainder of the results. For this reason, it is possible that the service will return fewer results than specified by maxresults, or than the default of 5000. </param>
        /// <param name="include"> Include this parameter to specify that the queues&apos; metadata be returned as part of the response body. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<ResponseWithHeaders<ListQueuesSegmentResponse, ServiceListQueuesSegmentHeaders>> ListQueuesSegmentNextPageAsync(string nextLink, string prefix = null, string marker = null, int? maxresults = null, IEnumerable<string> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListQueuesSegmentNextPageRequest(nextLink, prefix, marker, maxresults, include, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceListQueuesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListQueuesSegmentResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListQueuesSegmentResponse.DeserializeListQueuesSegmentResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The List Queues Segment operation returns a list of the queues under the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="prefix"> Filters the results to return only queues whose name begins with the specified prefix. </param>
        /// <param name="marker"> A string value that identifies the portion of the list of queues to be returned with the next listing operation. The operation returns the NextMarker value within the response body if the listing operation did not return all queues remaining to be listed with the current page. The NextMarker value can be used as the value for the marker parameter in a subsequent call to request the next page of list items. The marker value is opaque to the client. </param>
        /// <param name="maxresults"> Specifies the maximum number of queues to return. If the request does not specify maxresults, or specifies a value greater than 5000, the server will return up to 5000 items. Note that if the listing operation crosses a partition boundary, then the service will return a continuation token for retrieving the remainder of the results. For this reason, it is possible that the service will return fewer results than specified by maxresults, or than the default of 5000. </param>
        /// <param name="include"> Include this parameter to specify that the queues&apos; metadata be returned as part of the response body. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public ResponseWithHeaders<ListQueuesSegmentResponse, ServiceListQueuesSegmentHeaders> ListQueuesSegmentNextPage(string nextLink, string prefix = null, string marker = null, int? maxresults = null, IEnumerable<string> include = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListQueuesSegmentNextPageRequest(nextLink, prefix, marker, maxresults, include, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceListQueuesSegmentHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListQueuesSegmentResponse value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("EnumerationResults") is XElement enumerationResultsElement)
                        {
                            value = ListQueuesSegmentResponse.DeserializeListQueuesSegmentResponse(enumerationResultsElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
