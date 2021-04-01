// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Configuration of an App Service app.
    /// </summary>
    public partial class SiteConfig
    {
        /// <summary>
        /// Initializes a new instance of the SiteConfig class.
        /// </summary>
        public SiteConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteConfig class.
        /// </summary>
        /// <param name="numberOfWorkers">Number of workers.</param>
        /// <param name="defaultDocuments">Default documents.</param>
        /// <param name="netFrameworkVersion">.NET Framework version.</param>
        /// <param name="phpVersion">Version of PHP.</param>
        /// <param name="pythonVersion">Version of Python.</param>
        /// <param name="nodeVersion">Version of Node.js.</param>
        /// <param name="powerShellVersion">Version of PowerShell.</param>
        /// <param name="linuxFxVersion">Linux App Framework and
        /// version</param>
        /// <param name="windowsFxVersion">Xenon App Framework and
        /// version</param>
        /// <param name="requestTracingEnabled">&lt;code&gt;true&lt;/code&gt;
        /// if request tracing is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="requestTracingExpirationTime">Request tracing
        /// expiration time.</param>
        /// <param name="remoteDebuggingEnabled">&lt;code&gt;true&lt;/code&gt;
        /// if remote debugging is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="remoteDebuggingVersion">Remote debugging
        /// version.</param>
        /// <param name="httpLoggingEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// HTTP logging is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="logsDirectorySizeLimit">HTTP logs directory size
        /// limit.</param>
        /// <param
        /// name="detailedErrorLoggingEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// detailed error logging is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="publishingUsername">Publishing user name.</param>
        /// <param name="appSettings">Application settings.</param>
        /// <param name="azureStorageAccounts">List of Azure Storage
        /// Accounts.</param>
        /// <param name="connectionStrings">Connection strings.</param>
        /// <param name="machineKey">Site MachineKey.</param>
        /// <param name="handlerMappings">Handler mappings.</param>
        /// <param name="documentRoot">Document root.</param>
        /// <param name="scmType">SCM type. Possible values include: 'None',
        /// 'Dropbox', 'Tfs', 'LocalGit', 'GitHub', 'CodePlexGit',
        /// 'CodePlexHg', 'BitbucketGit', 'BitbucketHg', 'ExternalGit',
        /// 'ExternalHg', 'OneDrive', 'VSO', 'VSTSRM'</param>
        /// <param name="use32BitWorkerProcess">&lt;code&gt;true&lt;/code&gt;
        /// to use 32-bit worker process; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="webSocketsEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// WebSocket is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="alwaysOn">&lt;code&gt;true&lt;/code&gt; if Always On
        /// is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="javaVersion">Java version.</param>
        /// <param name="javaContainer">Java container.</param>
        /// <param name="javaContainerVersion">Java container version.</param>
        /// <param name="appCommandLine">App command line to launch.</param>
        /// <param name="managedPipelineMode">Managed pipeline mode. Possible
        /// values include: 'Integrated', 'Classic'</param>
        /// <param name="virtualApplications">Virtual applications.</param>
        /// <param name="loadBalancing">Site load balancing. Possible values
        /// include: 'WeightedRoundRobin', 'LeastRequests',
        /// 'LeastResponseTime', 'WeightedTotalTraffic', 'RequestHash',
        /// 'PerSiteRoundRobin'</param>
        /// <param name="experiments">This is work around for polymorphic
        /// types.</param>
        /// <param name="limits">Site limits.</param>
        /// <param name="autoHealEnabled">&lt;code&gt;true&lt;/code&gt; if Auto
        /// Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="autoHealRules">Auto Heal rules.</param>
        /// <param name="tracingOptions">Tracing options.</param>
        /// <param name="vnetName">Virtual Network name.</param>
        /// <param name="vnetRouteAllEnabled">Virtual Network Route All
        /// enabled. This causes all outbound traffic to have Virtual Network
        /// Security Groups and User Defined Routes applied.</param>
        /// <param name="vnetPrivatePortsCount">The number of private ports
        /// assigned to this app. These will be assigned dynamically on
        /// runtime.</param>
        /// <param name="cors">Cross-Origin Resource Sharing (CORS)
        /// settings.</param>
        /// <param name="push">Push endpoint settings.</param>
        /// <param name="apiDefinition">Information about the formal API
        /// definition for the app.</param>
        /// <param name="apiManagementConfig">Azure API management settings
        /// linked to the app.</param>
        /// <param name="autoSwapSlotName">Auto-swap slot name.</param>
        /// <param name="localMySqlEnabled">&lt;code&gt;true&lt;/code&gt; to
        /// enable local MySQL; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="managedServiceIdentityId">Managed Service Identity
        /// Id</param>
        /// <param name="xManagedServiceIdentityId">Explicit Managed Service
        /// Identity Id</param>
        /// <param name="keyVaultReferenceIdentity">Identity to use for Key
        /// Vault Reference authentication.</param>
        /// <param name="ipSecurityRestrictions">IP security restrictions for
        /// main.</param>
        /// <param name="scmIpSecurityRestrictions">IP security restrictions
        /// for scm.</param>
        /// <param name="scmIpSecurityRestrictionsUseMain">IP security
        /// restrictions for scm to use main.</param>
        /// <param name="http20Enabled">Http20Enabled: configures a web site to
        /// allow clients to connect over http2.0</param>
        /// <param name="minTlsVersion">MinTlsVersion: configures the minimum
        /// version of TLS required for SSL requests. Possible values include:
        /// '1.0', '1.1', '1.2'</param>
        /// <param name="scmMinTlsVersion">ScmMinTlsVersion: configures the
        /// minimum version of TLS required for SSL requests for SCM site.
        /// Possible values include: '1.0', '1.1', '1.2'</param>
        /// <param name="ftpsState">State of FTP / FTPS service. Possible
        /// values include: 'AllAllowed', 'FtpsOnly', 'Disabled'</param>
        /// <param name="preWarmedInstanceCount">Number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic
        /// Plans</param>
        /// <param name="functionAppScaleLimit">Maximum number of workers that
        /// a site can scale out to.
        /// This setting only applies to the Consumption and Elastic Premium
        /// Plans</param>
        /// <param name="healthCheckPath">Health check path</param>
        /// <param name="functionsRuntimeScaleMonitoringEnabled">Gets or sets a
        /// value indicating whether functions runtime scale monitoring is
        /// enabled. When enabled,
        /// the ScaleController will not monitor event sources directly, but
        /// will instead call to the
        /// runtime to get scale status.</param>
        /// <param name="websiteTimeZone">Sets the time zone a site uses for
        /// generating timestamps. Compatible with Linux and Windows App
        /// Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence
        /// over this config. For Linux, expects tz database values
        /// https://www.iana.org/time-zones (for a quick reference see
        /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For
        /// Windows, expects one of the time zones listed under
        /// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows
        /// NT\CurrentVersion\Time Zones</param>
        /// <param name="minimumElasticInstanceCount">Number of minimum
        /// instance count for a site
        /// This setting only applies to the Elastic Plans</param>
        public SiteConfig(int? numberOfWorkers = default(int?), IList<string> defaultDocuments = default(IList<string>), string netFrameworkVersion = default(string), string phpVersion = default(string), string pythonVersion = default(string), string nodeVersion = default(string), string powerShellVersion = default(string), string linuxFxVersion = default(string), string windowsFxVersion = default(string), bool? requestTracingEnabled = default(bool?), System.DateTime? requestTracingExpirationTime = default(System.DateTime?), bool? remoteDebuggingEnabled = default(bool?), string remoteDebuggingVersion = default(string), bool? httpLoggingEnabled = default(bool?), int? logsDirectorySizeLimit = default(int?), bool? detailedErrorLoggingEnabled = default(bool?), string publishingUsername = default(string), IList<NameValuePair> appSettings = default(IList<NameValuePair>), IDictionary<string, AzureStorageInfoValue> azureStorageAccounts = default(IDictionary<string, AzureStorageInfoValue>), IList<ConnStringInfo> connectionStrings = default(IList<ConnStringInfo>), SiteMachineKey machineKey = default(SiteMachineKey), IList<HandlerMapping> handlerMappings = default(IList<HandlerMapping>), string documentRoot = default(string), string scmType = default(string), bool? use32BitWorkerProcess = default(bool?), bool? webSocketsEnabled = default(bool?), bool? alwaysOn = default(bool?), string javaVersion = default(string), string javaContainer = default(string), string javaContainerVersion = default(string), string appCommandLine = default(string), ManagedPipelineMode? managedPipelineMode = default(ManagedPipelineMode?), IList<VirtualApplication> virtualApplications = default(IList<VirtualApplication>), SiteLoadBalancing? loadBalancing = default(SiteLoadBalancing?), Experiments experiments = default(Experiments), SiteLimits limits = default(SiteLimits), bool? autoHealEnabled = default(bool?), AutoHealRules autoHealRules = default(AutoHealRules), string tracingOptions = default(string), string vnetName = default(string), bool? vnetRouteAllEnabled = default(bool?), int? vnetPrivatePortsCount = default(int?), CorsSettings cors = default(CorsSettings), PushSettings push = default(PushSettings), ApiDefinitionInfo apiDefinition = default(ApiDefinitionInfo), ApiManagementConfig apiManagementConfig = default(ApiManagementConfig), string autoSwapSlotName = default(string), bool? localMySqlEnabled = default(bool?), int? managedServiceIdentityId = default(int?), int? xManagedServiceIdentityId = default(int?), string keyVaultReferenceIdentity = default(string), IList<IpSecurityRestriction> ipSecurityRestrictions = default(IList<IpSecurityRestriction>), IList<IpSecurityRestriction> scmIpSecurityRestrictions = default(IList<IpSecurityRestriction>), bool? scmIpSecurityRestrictionsUseMain = default(bool?), bool? http20Enabled = default(bool?), string minTlsVersion = default(string), string scmMinTlsVersion = default(string), string ftpsState = default(string), int? preWarmedInstanceCount = default(int?), int? functionAppScaleLimit = default(int?), string healthCheckPath = default(string), bool? functionsRuntimeScaleMonitoringEnabled = default(bool?), string websiteTimeZone = default(string), int? minimumElasticInstanceCount = default(int?))
        {
            NumberOfWorkers = numberOfWorkers;
            DefaultDocuments = defaultDocuments;
            NetFrameworkVersion = netFrameworkVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            NodeVersion = nodeVersion;
            PowerShellVersion = powerShellVersion;
            LinuxFxVersion = linuxFxVersion;
            WindowsFxVersion = windowsFxVersion;
            RequestTracingEnabled = requestTracingEnabled;
            RequestTracingExpirationTime = requestTracingExpirationTime;
            RemoteDebuggingEnabled = remoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            HttpLoggingEnabled = httpLoggingEnabled;
            LogsDirectorySizeLimit = logsDirectorySizeLimit;
            DetailedErrorLoggingEnabled = detailedErrorLoggingEnabled;
            PublishingUsername = publishingUsername;
            AppSettings = appSettings;
            AzureStorageAccounts = azureStorageAccounts;
            ConnectionStrings = connectionStrings;
            MachineKey = machineKey;
            HandlerMappings = handlerMappings;
            DocumentRoot = documentRoot;
            ScmType = scmType;
            Use32BitWorkerProcess = use32BitWorkerProcess;
            WebSocketsEnabled = webSocketsEnabled;
            AlwaysOn = alwaysOn;
            JavaVersion = javaVersion;
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            AppCommandLine = appCommandLine;
            ManagedPipelineMode = managedPipelineMode;
            VirtualApplications = virtualApplications;
            LoadBalancing = loadBalancing;
            Experiments = experiments;
            Limits = limits;
            AutoHealEnabled = autoHealEnabled;
            AutoHealRules = autoHealRules;
            TracingOptions = tracingOptions;
            VnetName = vnetName;
            VnetRouteAllEnabled = vnetRouteAllEnabled;
            VnetPrivatePortsCount = vnetPrivatePortsCount;
            Cors = cors;
            Push = push;
            ApiDefinition = apiDefinition;
            ApiManagementConfig = apiManagementConfig;
            AutoSwapSlotName = autoSwapSlotName;
            LocalMySqlEnabled = localMySqlEnabled;
            ManagedServiceIdentityId = managedServiceIdentityId;
            XManagedServiceIdentityId = xManagedServiceIdentityId;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            IpSecurityRestrictions = ipSecurityRestrictions;
            ScmIpSecurityRestrictions = scmIpSecurityRestrictions;
            ScmIpSecurityRestrictionsUseMain = scmIpSecurityRestrictionsUseMain;
            Http20Enabled = http20Enabled;
            MinTlsVersion = minTlsVersion;
            ScmMinTlsVersion = scmMinTlsVersion;
            FtpsState = ftpsState;
            PreWarmedInstanceCount = preWarmedInstanceCount;
            FunctionAppScaleLimit = functionAppScaleLimit;
            HealthCheckPath = healthCheckPath;
            FunctionsRuntimeScaleMonitoringEnabled = functionsRuntimeScaleMonitoringEnabled;
            WebsiteTimeZone = websiteTimeZone;
            MinimumElasticInstanceCount = minimumElasticInstanceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of workers.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Gets or sets default documents.
        /// </summary>
        [JsonProperty(PropertyName = "defaultDocuments")]
        public IList<string> DefaultDocuments { get; set; }

        /// <summary>
        /// Gets or sets .NET Framework version.
        /// </summary>
        [JsonProperty(PropertyName = "netFrameworkVersion")]
        public string NetFrameworkVersion { get; set; }

        /// <summary>
        /// Gets or sets version of PHP.
        /// </summary>
        [JsonProperty(PropertyName = "phpVersion")]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Gets or sets version of Python.
        /// </summary>
        [JsonProperty(PropertyName = "pythonVersion")]
        public string PythonVersion { get; set; }

        /// <summary>
        /// Gets or sets version of Node.js.
        /// </summary>
        [JsonProperty(PropertyName = "nodeVersion")]
        public string NodeVersion { get; set; }

        /// <summary>
        /// Gets or sets version of PowerShell.
        /// </summary>
        [JsonProperty(PropertyName = "powerShellVersion")]
        public string PowerShellVersion { get; set; }

        /// <summary>
        /// Gets or sets linux App Framework and version
        /// </summary>
        [JsonProperty(PropertyName = "linuxFxVersion")]
        public string LinuxFxVersion { get; set; }

        /// <summary>
        /// Gets or sets xenon App Framework and version
        /// </summary>
        [JsonProperty(PropertyName = "windowsFxVersion")]
        public string WindowsFxVersion { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// request tracing is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "requestTracingEnabled")]
        public bool? RequestTracingEnabled { get; set; }

        /// <summary>
        /// Gets or sets request tracing expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "requestTracingExpirationTime")]
        public System.DateTime? RequestTracingExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// remote debugging is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "remoteDebuggingEnabled")]
        public bool? RemoteDebuggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets remote debugging version.
        /// </summary>
        [JsonProperty(PropertyName = "remoteDebuggingVersion")]
        public string RemoteDebuggingVersion { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if HTTP
        /// logging is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "httpLoggingEnabled")]
        public bool? HttpLoggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets HTTP logs directory size limit.
        /// </summary>
        [JsonProperty(PropertyName = "logsDirectorySizeLimit")]
        public int? LogsDirectorySizeLimit { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// detailed error logging is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "detailedErrorLoggingEnabled")]
        public bool? DetailedErrorLoggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets publishing user name.
        /// </summary>
        [JsonProperty(PropertyName = "publishingUsername")]
        public string PublishingUsername { get; set; }

        /// <summary>
        /// Gets or sets application settings.
        /// </summary>
        [JsonProperty(PropertyName = "appSettings")]
        public IList<NameValuePair> AppSettings { get; set; }

        /// <summary>
        /// Gets or sets list of Azure Storage Accounts.
        /// </summary>
        [JsonProperty(PropertyName = "azureStorageAccounts")]
        public IDictionary<string, AzureStorageInfoValue> AzureStorageAccounts { get; set; }

        /// <summary>
        /// Gets or sets connection strings.
        /// </summary>
        [JsonProperty(PropertyName = "connectionStrings")]
        public IList<ConnStringInfo> ConnectionStrings { get; set; }

        /// <summary>
        /// Gets site MachineKey.
        /// </summary>
        [JsonProperty(PropertyName = "machineKey")]
        public SiteMachineKey MachineKey { get; private set; }

        /// <summary>
        /// Gets or sets handler mappings.
        /// </summary>
        [JsonProperty(PropertyName = "handlerMappings")]
        public IList<HandlerMapping> HandlerMappings { get; set; }

        /// <summary>
        /// Gets or sets document root.
        /// </summary>
        [JsonProperty(PropertyName = "documentRoot")]
        public string DocumentRoot { get; set; }

        /// <summary>
        /// Gets or sets SCM type. Possible values include: 'None', 'Dropbox',
        /// 'Tfs', 'LocalGit', 'GitHub', 'CodePlexGit', 'CodePlexHg',
        /// 'BitbucketGit', 'BitbucketHg', 'ExternalGit', 'ExternalHg',
        /// 'OneDrive', 'VSO', 'VSTSRM'
        /// </summary>
        [JsonProperty(PropertyName = "scmType")]
        public string ScmType { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to use
        /// 32-bit worker process; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "use32BitWorkerProcess")]
        public bool? Use32BitWorkerProcess { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// WebSocket is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "webSocketsEnabled")]
        public bool? WebSocketsEnabled { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// Always On is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "alwaysOn")]
        public bool? AlwaysOn { get; set; }

        /// <summary>
        /// Gets or sets java version.
        /// </summary>
        [JsonProperty(PropertyName = "javaVersion")]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Gets or sets java container.
        /// </summary>
        [JsonProperty(PropertyName = "javaContainer")]
        public string JavaContainer { get; set; }

        /// <summary>
        /// Gets or sets java container version.
        /// </summary>
        [JsonProperty(PropertyName = "javaContainerVersion")]
        public string JavaContainerVersion { get; set; }

        /// <summary>
        /// Gets or sets app command line to launch.
        /// </summary>
        [JsonProperty(PropertyName = "appCommandLine")]
        public string AppCommandLine { get; set; }

        /// <summary>
        /// Gets or sets managed pipeline mode. Possible values include:
        /// 'Integrated', 'Classic'
        /// </summary>
        [JsonProperty(PropertyName = "managedPipelineMode")]
        public ManagedPipelineMode? ManagedPipelineMode { get; set; }

        /// <summary>
        /// Gets or sets virtual applications.
        /// </summary>
        [JsonProperty(PropertyName = "virtualApplications")]
        public IList<VirtualApplication> VirtualApplications { get; set; }

        /// <summary>
        /// Gets or sets site load balancing. Possible values include:
        /// 'WeightedRoundRobin', 'LeastRequests', 'LeastResponseTime',
        /// 'WeightedTotalTraffic', 'RequestHash', 'PerSiteRoundRobin'
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancing")]
        public SiteLoadBalancing? LoadBalancing { get; set; }

        /// <summary>
        /// Gets or sets this is work around for polymorphic types.
        /// </summary>
        [JsonProperty(PropertyName = "experiments")]
        public Experiments Experiments { get; set; }

        /// <summary>
        /// Gets or sets site limits.
        /// </summary>
        [JsonProperty(PropertyName = "limits")]
        public SiteLimits Limits { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if Auto
        /// Heal is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "autoHealEnabled")]
        public bool? AutoHealEnabled { get; set; }

        /// <summary>
        /// Gets or sets auto Heal rules.
        /// </summary>
        [JsonProperty(PropertyName = "autoHealRules")]
        public AutoHealRules AutoHealRules { get; set; }

        /// <summary>
        /// Gets or sets tracing options.
        /// </summary>
        [JsonProperty(PropertyName = "tracingOptions")]
        public string TracingOptions { get; set; }

        /// <summary>
        /// Gets or sets virtual Network name.
        /// </summary>
        [JsonProperty(PropertyName = "vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Gets or sets virtual Network Route All enabled. This causes all
        /// outbound traffic to have Virtual Network Security Groups and User
        /// Defined Routes applied.
        /// </summary>
        [JsonProperty(PropertyName = "vnetRouteAllEnabled")]
        public bool? VnetRouteAllEnabled { get; set; }

        /// <summary>
        /// Gets or sets the number of private ports assigned to this app.
        /// These will be assigned dynamically on runtime.
        /// </summary>
        [JsonProperty(PropertyName = "vnetPrivatePortsCount")]
        public int? VnetPrivatePortsCount { get; set; }

        /// <summary>
        /// Gets or sets cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [JsonProperty(PropertyName = "cors")]
        public CorsSettings Cors { get; set; }

        /// <summary>
        /// Gets or sets push endpoint settings.
        /// </summary>
        [JsonProperty(PropertyName = "push")]
        public PushSettings Push { get; set; }

        /// <summary>
        /// Gets or sets information about the formal API definition for the
        /// app.
        /// </summary>
        [JsonProperty(PropertyName = "apiDefinition")]
        public ApiDefinitionInfo ApiDefinition { get; set; }

        /// <summary>
        /// Gets or sets azure API management settings linked to the app.
        /// </summary>
        [JsonProperty(PropertyName = "apiManagementConfig")]
        public ApiManagementConfig ApiManagementConfig { get; set; }

        /// <summary>
        /// Gets or sets auto-swap slot name.
        /// </summary>
        [JsonProperty(PropertyName = "autoSwapSlotName")]
        public string AutoSwapSlotName { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// enable local MySQL; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "localMySqlEnabled")]
        public bool? LocalMySqlEnabled { get; set; }

        /// <summary>
        /// Gets or sets managed Service Identity Id
        /// </summary>
        [JsonProperty(PropertyName = "managedServiceIdentityId")]
        public int? ManagedServiceIdentityId { get; set; }

        /// <summary>
        /// Gets or sets explicit Managed Service Identity Id
        /// </summary>
        [JsonProperty(PropertyName = "xManagedServiceIdentityId")]
        public int? XManagedServiceIdentityId { get; set; }

        /// <summary>
        /// Gets or sets identity to use for Key Vault Reference
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions for main.
        /// </summary>
        [JsonProperty(PropertyName = "ipSecurityRestrictions")]
        public IList<IpSecurityRestriction> IpSecurityRestrictions { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions for scm.
        /// </summary>
        [JsonProperty(PropertyName = "scmIpSecurityRestrictions")]
        public IList<IpSecurityRestriction> ScmIpSecurityRestrictions { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions for scm to use main.
        /// </summary>
        [JsonProperty(PropertyName = "scmIpSecurityRestrictionsUseMain")]
        public bool? ScmIpSecurityRestrictionsUseMain { get; set; }

        /// <summary>
        /// Gets or sets http20Enabled: configures a web site to allow clients
        /// to connect over http2.0
        /// </summary>
        [JsonProperty(PropertyName = "http20Enabled")]
        public bool? Http20Enabled { get; set; }

        /// <summary>
        /// Gets or sets minTlsVersion: configures the minimum version of TLS
        /// required for SSL requests. Possible values include: '1.0', '1.1',
        /// '1.2'
        /// </summary>
        [JsonProperty(PropertyName = "minTlsVersion")]
        public string MinTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets scmMinTlsVersion: configures the minimum version of
        /// TLS required for SSL requests for SCM site. Possible values
        /// include: '1.0', '1.1', '1.2'
        /// </summary>
        [JsonProperty(PropertyName = "scmMinTlsVersion")]
        public string ScmMinTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets state of FTP / FTPS service. Possible values include:
        /// 'AllAllowed', 'FtpsOnly', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "ftpsState")]
        public string FtpsState { get; set; }

        /// <summary>
        /// Gets or sets number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic Plans
        /// </summary>
        [JsonProperty(PropertyName = "preWarmedInstanceCount")]
        public int? PreWarmedInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets maximum number of workers that a site can scale out
        /// to.
        /// This setting only applies to the Consumption and Elastic Premium
        /// Plans
        /// </summary>
        [JsonProperty(PropertyName = "functionAppScaleLimit")]
        public int? FunctionAppScaleLimit { get; set; }

        /// <summary>
        /// Gets or sets health check path
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckPath")]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether functions runtime scale
        /// monitoring is enabled. When enabled,
        /// the ScaleController will not monitor event sources directly, but
        /// will instead call to the
        /// runtime to get scale status.
        /// </summary>
        [JsonProperty(PropertyName = "functionsRuntimeScaleMonitoringEnabled")]
        public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }

        /// <summary>
        /// Gets or sets sets the time zone a site uses for generating
        /// timestamps. Compatible with Linux and Windows App Service. Setting
        /// the WEBSITE_TIME_ZONE app setting takes precedence over this
        /// config. For Linux, expects tz database values
        /// https://www.iana.org/time-zones (for a quick reference see
        /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For
        /// Windows, expects one of the time zones listed under
        /// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows
        /// NT\CurrentVersion\Time Zones
        /// </summary>
        [JsonProperty(PropertyName = "websiteTimeZone")]
        public string WebsiteTimeZone { get; set; }

        /// <summary>
        /// Gets or sets number of minimum instance count for a site
        /// This setting only applies to the Elastic Plans
        /// </summary>
        [JsonProperty(PropertyName = "minimumElasticInstanceCount")]
        public int? MinimumElasticInstanceCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Push != null)
            {
                Push.Validate();
            }
            if (PreWarmedInstanceCount > 10)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PreWarmedInstanceCount", 10);
            }
            if (PreWarmedInstanceCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PreWarmedInstanceCount", 0);
            }
            if (FunctionAppScaleLimit < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "FunctionAppScaleLimit", 0);
            }
            if (MinimumElasticInstanceCount > 20)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MinimumElasticInstanceCount", 20);
            }
            if (MinimumElasticInstanceCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinimumElasticInstanceCount", 0);
            }
        }
    }
}
