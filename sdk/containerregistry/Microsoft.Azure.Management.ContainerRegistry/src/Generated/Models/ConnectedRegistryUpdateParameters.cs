// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for updating a connected registry.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectedRegistryUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ConnectedRegistryUpdateParameters
        /// class.
        /// </summary>
        public ConnectedRegistryUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectedRegistryUpdateParameters
        /// class.
        /// </summary>
        /// <param name="syncProperties">The sync properties of the connected
        /// registry with its parent.</param>
        /// <param name="logging">The logging properties of the connected
        /// registry.</param>
        /// <param name="clientTokenIds">The list of the ACR token resource IDs
        /// used to authenticate clients to the connected registry.</param>
        public ConnectedRegistryUpdateParameters(SyncUpdateProperties syncProperties = default(SyncUpdateProperties), LoggingProperties logging = default(LoggingProperties), IList<string> clientTokenIds = default(IList<string>))
        {
            SyncProperties = syncProperties;
            Logging = logging;
            ClientTokenIds = clientTokenIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sync properties of the connected registry with its
        /// parent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.syncProperties")]
        public SyncUpdateProperties SyncProperties { get; set; }

        /// <summary>
        /// Gets or sets the logging properties of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logging")]
        public LoggingProperties Logging { get; set; }

        /// <summary>
        /// Gets or sets the list of the ACR token resource IDs used to
        /// authenticate clients to the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientTokenIds")]
        public IList<string> ClientTokenIds { get; set; }

    }
}
