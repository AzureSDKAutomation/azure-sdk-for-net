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
    /// The parameters to provide for the Facebook channel.
    /// </summary>
    public partial class FacebookChannelProperties
    {
        /// <summary>
        /// Initializes a new instance of the FacebookChannelProperties class.
        /// </summary>
        public FacebookChannelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FacebookChannelProperties class.
        /// </summary>
        /// <param name="appId">Facebook application id</param>
        /// <param name="isEnabled">Whether this channel is enabled for the
        /// bot</param>
        /// <param name="verifyToken">Verify token. Value only returned through
        /// POST to the action Channel List API, otherwise empty.</param>
        /// <param name="pages">The list of Facebook pages</param>
        /// <param name="appSecret">Facebook application secret. Value only
        /// returned through POST to the action Channel List API, otherwise
        /// empty.</param>
        /// <param name="callbackUrl">Callback Url</param>
        public FacebookChannelProperties(string appId, bool isEnabled, string verifyToken = default(string), IList<FacebookPage> pages = default(IList<FacebookPage>), string appSecret = default(string), string callbackUrl = default(string))
        {
            VerifyToken = verifyToken;
            Pages = pages;
            AppId = appId;
            AppSecret = appSecret;
            CallbackUrl = callbackUrl;
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets verify token. Value only returned through POST to the action
        /// Channel List API, otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "verifyToken")]
        public string VerifyToken { get; private set; }

        /// <summary>
        /// Gets or sets the list of Facebook pages
        /// </summary>
        [JsonProperty(PropertyName = "pages")]
        public IList<FacebookPage> Pages { get; set; }

        /// <summary>
        /// Gets or sets facebook application id
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets facebook application secret. Value only returned
        /// through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "appSecret")]
        public string AppSecret { get; set; }

        /// <summary>
        /// Gets callback Url
        /// </summary>
        [JsonProperty(PropertyName = "callbackUrl")]
        public string CallbackUrl { get; private set; }

        /// <summary>
        /// Gets or sets whether this channel is enabled for the bot
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
            if (Pages != null)
            {
                foreach (var element in Pages)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
