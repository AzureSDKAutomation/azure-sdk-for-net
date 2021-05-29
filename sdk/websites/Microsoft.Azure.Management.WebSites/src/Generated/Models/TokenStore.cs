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
    /// The configuration settings of the token store.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TokenStore : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the TokenStore class.
        /// </summary>
        public TokenStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TokenStore class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="enabled">&lt;code&gt;true&lt;/code&gt; to durably
        /// store platform-specific security tokens that are obtained during
        /// login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// The default is &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="tokenRefreshExtensionHours">The number of hours after
        /// session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.</param>
        /// <param name="fileSystem">The configuration settings of the storage
        /// of the tokens if a file system is used.</param>
        /// <param name="azureBlobStorage">The configuration settings of the
        /// storage of the tokens if blob storage is used.</param>
        public TokenStore(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), bool? enabled = default(bool?), double? tokenRefreshExtensionHours = default(double?), FileSystemTokenStore fileSystem = default(FileSystemTokenStore), BlobStorageTokenStore azureBlobStorage = default(BlobStorageTokenStore))
            : base(id, name, kind, type, systemData)
        {
            Enabled = enabled;
            TokenRefreshExtensionHours = tokenRefreshExtensionHours;
            FileSystem = fileSystem;
            AzureBlobStorage = azureBlobStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// durably store platform-specific security tokens that are obtained
        /// during login flows; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// The default is &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the number of hours after session token expiration
        /// that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenRefreshExtensionHours")]
        public double? TokenRefreshExtensionHours { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the storage of the
        /// tokens if a file system is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileSystem")]
        public FileSystemTokenStore FileSystem { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the storage of the
        /// tokens if blob storage is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureBlobStorage")]
        public BlobStorageTokenStore AzureBlobStorage { get; set; }

    }
}
