// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A recoverable managed database resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecoverableManagedDatabase : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RecoverableManagedDatabase class.
        /// </summary>
        public RecoverableManagedDatabase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoverableManagedDatabase class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="lastAvailableBackupDate">The last available backup
        /// date.</param>
        public RecoverableManagedDatabase(string id = default(string), string name = default(string), string type = default(string), string lastAvailableBackupDate = default(string))
            : base(id, name, type)
        {
            LastAvailableBackupDate = lastAvailableBackupDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the last available backup date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastAvailableBackupDate")]
        public string LastAvailableBackupDate { get; private set; }

    }
}
