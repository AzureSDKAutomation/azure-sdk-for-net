// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MariaDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Microsoft Azure management API provides create, read, update, and
    /// delete functionality for Azure MariaDB resources including servers,
    /// databases, firewall rules, VNET rules, log files and configurations
    /// with new business model.
    /// </summary>
    public partial class MariaDBManagementClient : ServiceClient<MariaDBManagementClient>, IMariaDBManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IServersOperations.
        /// </summary>
        public virtual IServersOperations Servers { get; private set; }

        /// <summary>
        /// Gets the IReplicasOperations.
        /// </summary>
        public virtual IReplicasOperations Replicas { get; private set; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        public virtual IFirewallRulesOperations FirewallRules { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkRulesOperations.
        /// </summary>
        public virtual IVirtualNetworkRulesOperations VirtualNetworkRules { get; private set; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        public virtual IDatabasesOperations Databases { get; private set; }

        /// <summary>
        /// Gets the IConfigurationsOperations.
        /// </summary>
        public virtual IConfigurationsOperations Configurations { get; private set; }

        /// <summary>
        /// Gets the ILogFilesOperations.
        /// </summary>
        public virtual ILogFilesOperations LogFiles { get; private set; }

        /// <summary>
        /// Gets the ILocationBasedPerformanceTierOperations.
        /// </summary>
        public virtual ILocationBasedPerformanceTierOperations LocationBasedPerformanceTier { get; private set; }

        /// <summary>
        /// Gets the ICheckNameAvailabilityOperations.
        /// </summary>
        public virtual ICheckNameAvailabilityOperations CheckNameAvailability { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IQueryTextsOperations.
        /// </summary>
        public virtual IQueryTextsOperations QueryTexts { get; private set; }

        /// <summary>
        /// Gets the ITopQueryStatisticsOperations.
        /// </summary>
        public virtual ITopQueryStatisticsOperations TopQueryStatistics { get; private set; }

        /// <summary>
        /// Gets the IWaitStatisticsOperations.
        /// </summary>
        public virtual IWaitStatisticsOperations WaitStatistics { get; private set; }

        /// <summary>
        /// Gets the IAdvisorsOperations.
        /// </summary>
        public virtual IAdvisorsOperations Advisors { get; private set; }

        /// <summary>
        /// Gets the IRecommendedActionsOperations.
        /// </summary>
        public virtual IRecommendedActionsOperations RecommendedActions { get; private set; }

        /// <summary>
        /// Gets the ILocationBasedRecommendedActionSessionsOperationStatusOperations.
        /// </summary>
        public virtual ILocationBasedRecommendedActionSessionsOperationStatusOperations LocationBasedRecommendedActionSessionsOperationStatus { get; private set; }

        /// <summary>
        /// Gets the ILocationBasedRecommendedActionSessionsResultOperations.
        /// </summary>
        public virtual ILocationBasedRecommendedActionSessionsResultOperations LocationBasedRecommendedActionSessionsResult { get; private set; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        public virtual IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        public virtual IPrivateLinkResourcesOperations PrivateLinkResources { get; private set; }

        /// <summary>
        /// Gets the IServerSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IServerSecurityAlertPoliciesOperations ServerSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling MariaDBManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected MariaDBManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected MariaDBManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected MariaDBManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected MariaDBManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected MariaDBManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MariaDBManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling MariaDBManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MariaDBManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MariaDBManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MariaDBManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MariaDBManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Servers = new ServersOperations(this);
            Replicas = new ReplicasOperations(this);
            FirewallRules = new FirewallRulesOperations(this);
            VirtualNetworkRules = new VirtualNetworkRulesOperations(this);
            Databases = new DatabasesOperations(this);
            Configurations = new ConfigurationsOperations(this);
            LogFiles = new LogFilesOperations(this);
            LocationBasedPerformanceTier = new LocationBasedPerformanceTierOperations(this);
            CheckNameAvailability = new CheckNameAvailabilityOperations(this);
            Operations = new Operations(this);
            QueryTexts = new QueryTextsOperations(this);
            TopQueryStatistics = new TopQueryStatisticsOperations(this);
            WaitStatistics = new WaitStatisticsOperations(this);
            Advisors = new AdvisorsOperations(this);
            RecommendedActions = new RecommendedActionsOperations(this);
            LocationBasedRecommendedActionSessionsOperationStatus = new LocationBasedRecommendedActionSessionsOperationStatusOperations(this);
            LocationBasedRecommendedActionSessionsResult = new LocationBasedRecommendedActionSessionsResultOperations(this);
            PrivateEndpointConnections = new PrivateEndpointConnectionsOperations(this);
            PrivateLinkResources = new PrivateLinkResourcesOperations(this);
            ServerSecurityAlertPolicies = new ServerSecurityAlertPoliciesOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2018-06-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ServerPropertiesForCreate>("createMode"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ServerPropertiesForCreate>("createMode"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
        /// <summary>
        /// Create recommendation action session for the advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='advisorName'>
        /// The advisor name for recommendation action.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<AzureOperationResponse> CreateRecommendedActionSessionWithHttpMessagesAsync(string resourceGroupName, string serverName, string advisorName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Send request
            AzureOperationResponse _response = await BeginCreateRecommendedActionSessionWithHttpMessagesAsync(resourceGroupName, serverName, advisorName, databaseName, customHeaders, cancellationToken).ConfigureAwait(false);
            return await this.GetPostOrDeleteOperationResultAsync(_response, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create recommendation action session for the advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='advisorName'>
        /// The advisor name for recommendation action.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse> BeginCreateRecommendedActionSessionWithHttpMessagesAsync(string resourceGroupName, string serverName, string advisorName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.ApiVersion");
            }
            if (ApiVersion != null)
            {
                if (ApiVersion.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ApiVersion", 1);
                }
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.SubscriptionId");
            }
            if (SubscriptionId != null)
            {
                if (SubscriptionId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SubscriptionId", 1);
                }
            }
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 90)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 90);
                }
                if (resourceGroupName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "^[-\\w\\._\\(\\)]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "^[-\\w\\._\\(\\)]+$");
                }
            }
            if (serverName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "serverName");
            }
            if (advisorName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "advisorName");
            }
            if (databaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "databaseName");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("advisorName", advisorName);
                tracingParameters.Add("databaseName", databaseName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "BeginCreateRecommendedActionSession", tracingParameters);
            }
            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMariaDB/servers/{serverName}/advisors/{advisorName}/createRecommendedActionSession").ToString();
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(SubscriptionId));
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{serverName}", System.Uri.EscapeDataString(serverName));
            _url = _url.Replace("{advisorName}", System.Uri.EscapeDataString(advisorName));
            List<string> _queryParameters = new List<string>();
            if (ApiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(ApiVersion)));
            }
            if (databaseName != null)
            {
                _queryParameters.Add(string.Format("databaseName={0}", System.Uri.EscapeDataString(databaseName)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (GenerateClientRequestId != null && GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 202)
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    CloudError _errorBody =  SafeJsonConvert.DeserializeObject<CloudError>(_responseContent, DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex = new CloudException(_errorBody.Message);
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_httpResponse.Headers.Contains("x-ms-request-id"))
                {
                    ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                }
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
