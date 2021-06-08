// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of SqlServerInstance.
    /// </summary>
    public partial class SqlServerInstanceProperties
    {
        /// <summary>
        /// Initializes a new instance of the SqlServerInstanceProperties
        /// class.
        /// </summary>
        public SqlServerInstanceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlServerInstanceProperties
        /// class.
        /// </summary>
        /// <param name="containerResourceId">ARM Resource id of the container
        /// resource (Azure Arc for Servers).</param>
        /// <param name="status">The cloud connectivity status.</param>
        /// <param name="version">SQL Server version.</param>
        /// <param name="edition">SQL Server edition.</param>
        /// <param name="createTime">The time when the resource was
        /// created.</param>
        /// <param name="vCore">The number of logical processors used by the
        /// SQL Server instance.</param>
        /// <param name="patchLevel">SQL Server update level.</param>
        /// <param name="collation">SQL Server collation.</param>
        /// <param name="currentVersion">SQL Server current version.</param>
        /// <param name="instanceName">SQL Server instance name.</param>
        /// <param name="tcpDynamicPorts">Dynamic TCP ports used by SQL
        /// Server.</param>
        /// <param name="tcpStaticPorts">Static TCP ports used by SQL
        /// Server.</param>
        /// <param name="productId">SQL Server product ID.</param>
        /// <param name="licenseType">SQL Server license type.</param>
        public SqlServerInstanceProperties(string containerResourceId, string status, string version = default(string), string edition = default(string), string createTime = default(string), string vCore = default(string), string patchLevel = default(string), string collation = default(string), string currentVersion = default(string), string instanceName = default(string), string tcpDynamicPorts = default(string), string tcpStaticPorts = default(string), string productId = default(string), string licenseType = default(string), string provisioningState = default(string))
        {
            Version = version;
            Edition = edition;
            ContainerResourceId = containerResourceId;
            CreateTime = createTime;
            VCore = vCore;
            Status = status;
            PatchLevel = patchLevel;
            Collation = collation;
            CurrentVersion = currentVersion;
            InstanceName = instanceName;
            TcpDynamicPorts = tcpDynamicPorts;
            TcpStaticPorts = tcpStaticPorts;
            ProductId = productId;
            LicenseType = licenseType;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL Server version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets SQL Server edition.
        /// </summary>
        [JsonProperty(PropertyName = "edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets ARM Resource id of the container resource (Azure Arc
        /// for Servers).
        /// </summary>
        [JsonProperty(PropertyName = "containerResourceId")]
        public string ContainerResourceId { get; set; }

        /// <summary>
        /// Gets the time when the resource was created.
        /// </summary>
        [JsonProperty(PropertyName = "createTime")]
        public string CreateTime { get; private set; }

        /// <summary>
        /// Gets or sets the number of logical processors used by the SQL
        /// Server instance.
        /// </summary>
        [JsonProperty(PropertyName = "vCore")]
        public string VCore { get; set; }

        /// <summary>
        /// Gets or sets the cloud connectivity status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets SQL Server update level.
        /// </summary>
        [JsonProperty(PropertyName = "patchLevel")]
        public string PatchLevel { get; set; }

        /// <summary>
        /// Gets or sets SQL Server collation.
        /// </summary>
        [JsonProperty(PropertyName = "collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets SQL Server current version.
        /// </summary>
        [JsonProperty(PropertyName = "currentVersion")]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Gets or sets SQL Server instance name.
        /// </summary>
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or sets dynamic TCP ports used by SQL Server.
        /// </summary>
        [JsonProperty(PropertyName = "tcpDynamicPorts")]
        public string TcpDynamicPorts { get; set; }

        /// <summary>
        /// Gets or sets static TCP ports used by SQL Server.
        /// </summary>
        [JsonProperty(PropertyName = "tcpStaticPorts")]
        public string TcpStaticPorts { get; set; }

        /// <summary>
        /// Gets or sets SQL Server product ID.
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets SQL Server license type.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
