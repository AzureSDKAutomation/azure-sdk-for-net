// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the Bot.
    /// </summary>
    public partial class BotProperties
    {
        /// <summary>
        /// Initializes a new instance of the BotProperties class.
        /// </summary>
        public BotProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BotProperties class.
        /// </summary>
        /// <param name="displayName">The Name of the bot</param>
        /// <param name="endpoint">The bot's endpoint</param>
        /// <param name="msaAppId">Microsoft App Id for the bot</param>
        /// <param name="description">The description of the bot</param>
        /// <param name="iconUrl">The Icon Url of the bot</param>
        /// <param name="endpointVersion">The bot's endpoint version</param>
        /// <param name="msaAppType">Microsoft App Type for the bot. Possible
        /// values include: 'UserAssignedMSI', 'SingleTenant',
        /// 'MultiTenant'</param>
        /// <param name="msaAppTenantId">Microsoft App Tenant Id for the
        /// bot</param>
        /// <param name="msaAppMSIResourceId">Microsoft App Managed Identity
        /// Resource Id for the bot</param>
        /// <param name="configuredChannels">Collection of channels for which
        /// the bot is configured</param>
        /// <param name="enabledChannels">Collection of channels for which the
        /// bot is enabled</param>
        /// <param name="developerAppInsightKey">The Application Insights
        /// key</param>
        /// <param name="developerAppInsightsApiKey">The Application Insights
        /// Api Key</param>
        /// <param name="developerAppInsightsApplicationId">The Application
        /// Insights App Id</param>
        /// <param name="luisAppIds">Collection of LUIS App Ids</param>
        /// <param name="luisKey">The LUIS Key</param>
        /// <param name="isCmekEnabled">Whether Cmek is enabled</param>
        /// <param name="cmekKeyVaultUrl">The CMK Url</param>
        /// <param name="isIsolated">Whether the bot is in an isolated
        /// network</param>
        /// <param name="schemaTransformationVersion">The channel schema
        /// transformation version for the bot</param>
        public BotProperties(string displayName, string endpoint, string msaAppId, string description = default(string), string iconUrl = default(string), string endpointVersion = default(string), MsaAppType? msaAppType = default(MsaAppType?), string msaAppTenantId = default(string), string msaAppMSIResourceId = default(string), IList<string> configuredChannels = default(IList<string>), IList<string> enabledChannels = default(IList<string>), string developerAppInsightKey = default(string), string developerAppInsightsApiKey = default(string), string developerAppInsightsApplicationId = default(string), IList<string> luisAppIds = default(IList<string>), string luisKey = default(string), bool? isCmekEnabled = default(bool?), string cmekKeyVaultUrl = default(string), bool? isIsolated = default(bool?), string schemaTransformationVersion = default(string))
        {
            DisplayName = displayName;
            Description = description;
            IconUrl = iconUrl;
            Endpoint = endpoint;
            EndpointVersion = endpointVersion;
            MsaAppType = msaAppType;
            MsaAppId = msaAppId;
            MsaAppTenantId = msaAppTenantId;
            MsaAppMSIResourceId = msaAppMSIResourceId;
            ConfiguredChannels = configuredChannels;
            EnabledChannels = enabledChannels;
            DeveloperAppInsightKey = developerAppInsightKey;
            DeveloperAppInsightsApiKey = developerAppInsightsApiKey;
            DeveloperAppInsightsApplicationId = developerAppInsightsApplicationId;
            LuisAppIds = luisAppIds;
            LuisKey = luisKey;
            IsCmekEnabled = isCmekEnabled;
            CmekKeyVaultUrl = cmekKeyVaultUrl;
            IsIsolated = isIsolated;
            SchemaTransformationVersion = schemaTransformationVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Name of the bot
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the bot
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Icon Url of the bot
        /// </summary>
        [JsonProperty(PropertyName = "iconUrl")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or sets the bot's endpoint
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets the bot's endpoint version
        /// </summary>
        [JsonProperty(PropertyName = "endpointVersion")]
        public string EndpointVersion { get; private set; }

        /// <summary>
        /// Gets or sets microsoft App Type for the bot. Possible values
        /// include: 'UserAssignedMSI', 'SingleTenant', 'MultiTenant'
        /// </summary>
        [JsonProperty(PropertyName = "msaAppType")]
        public MsaAppType? MsaAppType { get; set; }

        /// <summary>
        /// Gets or sets microsoft App Id for the bot
        /// </summary>
        [JsonProperty(PropertyName = "msaAppId")]
        public string MsaAppId { get; set; }

        /// <summary>
        /// Gets or sets microsoft App Tenant Id for the bot
        /// </summary>
        [JsonProperty(PropertyName = "msaAppTenantId")]
        public string MsaAppTenantId { get; set; }

        /// <summary>
        /// Gets or sets microsoft App Managed Identity Resource Id for the bot
        /// </summary>
        [JsonProperty(PropertyName = "msaAppMSIResourceId")]
        public string MsaAppMSIResourceId { get; set; }

        /// <summary>
        /// Gets collection of channels for which the bot is configured
        /// </summary>
        [JsonProperty(PropertyName = "configuredChannels")]
        public IList<string> ConfiguredChannels { get; private set; }

        /// <summary>
        /// Gets collection of channels for which the bot is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabledChannels")]
        public IList<string> EnabledChannels { get; private set; }

        /// <summary>
        /// Gets or sets the Application Insights key
        /// </summary>
        [JsonProperty(PropertyName = "developerAppInsightKey")]
        public string DeveloperAppInsightKey { get; set; }

        /// <summary>
        /// Gets or sets the Application Insights Api Key
        /// </summary>
        [JsonProperty(PropertyName = "developerAppInsightsApiKey")]
        public string DeveloperAppInsightsApiKey { get; set; }

        /// <summary>
        /// Gets or sets the Application Insights App Id
        /// </summary>
        [JsonProperty(PropertyName = "developerAppInsightsApplicationId")]
        public string DeveloperAppInsightsApplicationId { get; set; }

        /// <summary>
        /// Gets or sets collection of LUIS App Ids
        /// </summary>
        [JsonProperty(PropertyName = "luisAppIds")]
        public IList<string> LuisAppIds { get; set; }

        /// <summary>
        /// Gets or sets the LUIS Key
        /// </summary>
        [JsonProperty(PropertyName = "luisKey")]
        public string LuisKey { get; set; }

        /// <summary>
        /// Gets or sets whether Cmek is enabled
        /// </summary>
        [JsonProperty(PropertyName = "isCmekEnabled")]
        public bool? IsCmekEnabled { get; set; }

        /// <summary>
        /// Gets or sets the CMK Url
        /// </summary>
        [JsonProperty(PropertyName = "cmekKeyVaultUrl")]
        public string CmekKeyVaultUrl { get; set; }

        /// <summary>
        /// Gets or sets whether the bot is in an isolated network
        /// </summary>
        [JsonProperty(PropertyName = "isIsolated")]
        public bool? IsIsolated { get; set; }

        /// <summary>
        /// Gets or sets the channel schema transformation version for the bot
        /// </summary>
        [JsonProperty(PropertyName = "schemaTransformationVersion")]
        public string SchemaTransformationVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (MsaAppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MsaAppId");
            }
        }
    }
}
