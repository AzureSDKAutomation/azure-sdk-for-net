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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The response body returned for a request to Bot Service Management to
    /// check per subscription hostSettings
    /// </summary>
    public partial class HostSettingsResponse
    {
        /// <summary>
        /// Initializes a new instance of the HostSettingsResponse class.
        /// </summary>
        public HostSettingsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostSettingsResponse class.
        /// </summary>
        /// <param name="oAuthUrl">For in-conversation bot user
        /// authentication</param>
        /// <param name="toBotFromChannelOpenIdMetadataUrl">For verifying
        /// incoming tokens from the channels</param>
        /// <param name="toBotFromChannelTokenIssuer">For verifying incoming
        /// tokens from the channels</param>
        /// <param name="toBotFromEmulatorOpenIdMetadataUrl">For verifying
        /// incoming tokens from bot emulator</param>
        /// <param name="toChannelFromBotLoginUrl">For getting access token to
        /// channels from bot host</param>
        /// <param name="toChannelFromBotOAuthScope">For getting access token
        /// to channels from bot host</param>
        /// <param name="validateAuthority">Per cloud OAuth setting on whether
        /// authority is validated</param>
        /// <param name="botOpenIdMetadata">Same as
        /// ToBotFromChannelOpenIdMetadataUrl, used by SDK &lt; v4.12</param>
        public HostSettingsResponse(string oAuthUrl = default(string), string toBotFromChannelOpenIdMetadataUrl = default(string), string toBotFromChannelTokenIssuer = default(string), string toBotFromEmulatorOpenIdMetadataUrl = default(string), string toChannelFromBotLoginUrl = default(string), string toChannelFromBotOAuthScope = default(string), bool? validateAuthority = default(bool?), string botOpenIdMetadata = default(string))
        {
            OAuthUrl = oAuthUrl;
            ToBotFromChannelOpenIdMetadataUrl = toBotFromChannelOpenIdMetadataUrl;
            ToBotFromChannelTokenIssuer = toBotFromChannelTokenIssuer;
            ToBotFromEmulatorOpenIdMetadataUrl = toBotFromEmulatorOpenIdMetadataUrl;
            ToChannelFromBotLoginUrl = toChannelFromBotLoginUrl;
            ToChannelFromBotOAuthScope = toChannelFromBotOAuthScope;
            ValidateAuthority = validateAuthority;
            BotOpenIdMetadata = botOpenIdMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets for in-conversation bot user authentication
        /// </summary>
        [JsonProperty(PropertyName = "OAuthUrl")]
        public string OAuthUrl { get; set; }

        /// <summary>
        /// Gets or sets for verifying incoming tokens from the channels
        /// </summary>
        [JsonProperty(PropertyName = "ToBotFromChannelOpenIdMetadataUrl")]
        public string ToBotFromChannelOpenIdMetadataUrl { get; set; }

        /// <summary>
        /// Gets or sets for verifying incoming tokens from the channels
        /// </summary>
        [JsonProperty(PropertyName = "ToBotFromChannelTokenIssuer")]
        public string ToBotFromChannelTokenIssuer { get; set; }

        /// <summary>
        /// Gets or sets for verifying incoming tokens from bot emulator
        /// </summary>
        [JsonProperty(PropertyName = "ToBotFromEmulatorOpenIdMetadataUrl")]
        public string ToBotFromEmulatorOpenIdMetadataUrl { get; set; }

        /// <summary>
        /// Gets or sets for getting access token to channels from bot host
        /// </summary>
        [JsonProperty(PropertyName = "ToChannelFromBotLoginUrl")]
        public string ToChannelFromBotLoginUrl { get; set; }

        /// <summary>
        /// Gets or sets for getting access token to channels from bot host
        /// </summary>
        [JsonProperty(PropertyName = "ToChannelFromBotOAuthScope")]
        public string ToChannelFromBotOAuthScope { get; set; }

        /// <summary>
        /// Gets or sets per cloud OAuth setting on whether authority is
        /// validated
        /// </summary>
        [JsonProperty(PropertyName = "ValidateAuthority")]
        public bool? ValidateAuthority { get; set; }

        /// <summary>
        /// Gets or sets same as ToBotFromChannelOpenIdMetadataUrl, used by SDK
        /// &amp;lt; v4.12
        /// </summary>
        [JsonProperty(PropertyName = "BotOpenIdMetadata")]
        public string BotOpenIdMetadata { get; set; }

    }
}
