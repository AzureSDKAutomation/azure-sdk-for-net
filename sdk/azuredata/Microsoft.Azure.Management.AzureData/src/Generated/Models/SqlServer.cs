// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureData.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A SQL server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlServer : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlServer class.
        /// </summary>
        public SqlServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlServer class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="cores">Cores of the Sql Server.</param>
        /// <param name="version">Version of the Sql Server.</param>
        /// <param name="edition">Sql Server Edition.</param>
        /// <param name="registrationID">ID for Parent Sql Server
        /// Registration.</param>
        /// <param name="propertyBag">Sql Server Json Property Bag.</param>
        public SqlServer(string id = default(string), string name = default(string), string type = default(string), int? cores = default(int?), string version = default(string), string edition = default(string), string registrationID = default(string), string propertyBag = default(string))
            : base(id, name, type)
        {
            Cores = cores;
            Version = version;
            Edition = edition;
            RegistrationID = registrationID;
            PropertyBag = propertyBag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets cores of the Sql Server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cores")]
        public int? Cores { get; set; }

        /// <summary>
        /// Gets or sets version of the Sql Server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets sql Server Edition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets ID for Parent Sql Server Registration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationID")]
        public string RegistrationID { get; set; }

        /// <summary>
        /// Gets or sets sql Server Json Property Bag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.propertyBag")]
        public string PropertyBag { get; set; }

    }
}
