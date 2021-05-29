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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the app registration for providers that
    /// have app ids and app secrets
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AppRegistration : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the AppRegistration class.
        /// </summary>
        public AppRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppRegistration class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="appId">The App ID of the app used for login.</param>
        /// <param name="appSecretSettingName">The app setting name that
        /// contains the app secret.</param>
        public AppRegistration(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string appId = default(string), string appSecretSettingName = default(string))
            : base(id, name, kind, type, systemData)
        {
            AppId = appId;
            AppSecretSettingName = appSecretSettingName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the App ID of the app used for login.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the app setting name that contains the app secret.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSecretSettingName")]
        public string AppSecretSettingName { get; set; }

    }
}
