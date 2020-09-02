// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// External Property.
    /// </summary>
    public partial class External
    {
        /// <summary>
        /// Initializes a new instance of the External class.
        /// </summary>
        public External()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the External class.
        /// </summary>
        public External(StorageAccount storageAccount = default(StorageAccount), string container = default(string), string path = default(string))
        {
            StorageAccount = storageAccount;
            Container = container;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "storageAccount")]
        public StorageAccount StorageAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}
