// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ListWorkspaceKeysResult
    {
        /// <summary>
        /// Initializes a new instance of the ListWorkspaceKeysResult class.
        /// </summary>
        public ListWorkspaceKeysResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListWorkspaceKeysResult class.
        /// </summary>
        public ListWorkspaceKeysResult(string userStorageKey = default(string), string userStorageResourceId = default(string), string appInsightsInstrumentationKey = default(string), RegistryListCredentialsResult containerRegistryCredentials = default(RegistryListCredentialsResult))
        {
            UserStorageKey = userStorageKey;
            UserStorageResourceId = userStorageResourceId;
            AppInsightsInstrumentationKey = appInsightsInstrumentationKey;
            ContainerRegistryCredentials = containerRegistryCredentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userStorageKey")]
        public string UserStorageKey { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userStorageResourceId")]
        public string UserStorageResourceId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appInsightsInstrumentationKey")]
        public string AppInsightsInstrumentationKey { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containerRegistryCredentials")]
        public RegistryListCredentialsResult ContainerRegistryCredentials { get; private set; }

    }
}
