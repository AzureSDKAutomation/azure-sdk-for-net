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
    /// An object that represents a connected registry for a container
    /// registry.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectedRegistry : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectedRegistry class.
        /// </summary>
        public ConnectedRegistry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectedRegistry class.
        /// </summary>
        /// <param name="mode">The mode of the connected registry resource that
        /// indicates the permissions of the registry. Possible values include:
        /// 'Registry', 'Mirror'</param>
        /// <param name="parent">The parent of the connected registry.</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="version">The current version of ACR runtime on the
        /// connected registry.</param>
        /// <param name="connectionState">The current connection state of the
        /// connected registry. Possible values include: 'Online', 'Offline',
        /// 'Syncing', 'Unhealthy'</param>
        /// <param name="lastActivityTime">The last activity time of the
        /// connected registry.</param>
        /// <param name="activation">The activation properties of the connected
        /// registry.</param>
        /// <param name="clientTokenIds">The list of the ACR token resource IDs
        /// used to authenticate clients to the connected registry.</param>
        /// <param name="loginServer">The login server properties of the
        /// connected registry.</param>
        /// <param name="logging">The logging properties of the connected
        /// registry.</param>
        /// <param name="statusDetails">The list of current statuses of the
        /// connected registry.</param>
        public ConnectedRegistry(string mode, ParentProperties parent, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string), string version = default(string), string connectionState = default(string), System.DateTime? lastActivityTime = default(System.DateTime?), ActivationProperties activation = default(ActivationProperties), IList<string> clientTokenIds = default(IList<string>), LoginServerProperties loginServer = default(LoginServerProperties), LoggingProperties logging = default(LoggingProperties), IList<StatusDetailProperties> statusDetails = default(IList<StatusDetailProperties>))
            : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            Mode = mode;
            Version = version;
            ConnectionState = connectionState;
            LastActivityTime = lastActivityTime;
            Activation = activation;
            Parent = parent;
            ClientTokenIds = clientTokenIds;
            LoginServer = loginServer;
            Logging = logging;
            StatusDetails = statusDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the resource. Possible values include:
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the mode of the connected registry resource that
        /// indicates the permissions of the registry. Possible values include:
        /// 'Registry', 'Mirror'
        /// </summary>
        [JsonProperty(PropertyName = "properties.mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets the current version of ACR runtime on the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the current connection state of the connected registry.
        /// Possible values include: 'Online', 'Offline', 'Syncing',
        /// 'Unhealthy'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionState")]
        public string ConnectionState { get; private set; }

        /// <summary>
        /// Gets the last activity time of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastActivityTime")]
        public System.DateTime? LastActivityTime { get; private set; }

        /// <summary>
        /// Gets the activation properties of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activation")]
        public ActivationProperties Activation { get; private set; }

        /// <summary>
        /// Gets or sets the parent of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parent")]
        public ParentProperties Parent { get; set; }

        /// <summary>
        /// Gets or sets the list of the ACR token resource IDs used to
        /// authenticate clients to the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientTokenIds")]
        public IList<string> ClientTokenIds { get; set; }

        /// <summary>
        /// Gets or sets the login server properties of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loginServer")]
        public LoginServerProperties LoginServer { get; set; }

        /// <summary>
        /// Gets or sets the logging properties of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logging")]
        public LoggingProperties Logging { get; set; }

        /// <summary>
        /// Gets the list of current statuses of the connected registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusDetails")]
        public IList<StatusDetailProperties> StatusDetails { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Mode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mode");
            }
            if (Parent == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parent");
            }
            if (Parent != null)
            {
                Parent.Validate();
            }
        }
    }
}
