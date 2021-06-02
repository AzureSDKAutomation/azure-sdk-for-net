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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Non versioned Worker App configuration properties that define the
    /// mutable settings of a worker app
    /// </summary>
    public partial class WorkerAppConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the WorkerAppConfiguration class.
        /// </summary>
        public WorkerAppConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkerAppConfiguration class.
        /// </summary>
        /// <param name="secrets">Collection of secrets used by a worker
        /// app</param>
        /// <param name="ingress">Ingress configurations.</param>
        /// <param name="registries">Collection of private container registry
        /// credentials for containers used by the worker app</param>
        public WorkerAppConfiguration(IList<WorkerAppSecret> secrets = default(IList<WorkerAppSecret>), WorkerAppIngress ingress = default(WorkerAppIngress), IList<WorkerAppRegistryCredentials> registries = default(IList<WorkerAppRegistryCredentials>))
        {
            Secrets = secrets;
            Ingress = ingress;
            Registries = registries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of secrets used by a worker app
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<WorkerAppSecret> Secrets { get; set; }

        /// <summary>
        /// Gets or sets ingress configurations.
        /// </summary>
        [JsonProperty(PropertyName = "ingress")]
        public WorkerAppIngress Ingress { get; set; }

        /// <summary>
        /// Gets or sets collection of private container registry credentials
        /// for containers used by the worker app
        /// </summary>
        [JsonProperty(PropertyName = "registries")]
        public IList<WorkerAppRegistryCredentials> Registries { get; set; }

    }
}
