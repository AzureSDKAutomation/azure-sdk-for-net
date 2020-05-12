// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WindowsIoT.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The description of the Windows IoT Device Service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DeviceService : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the DeviceService class.
        /// </summary>
        public DeviceService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceService class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The Azure Region where the resource
        /// lives</param>
        /// <param name="etag">The Etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal ETag convention.</param>
        /// <param name="notes">Windows IoT Device Service notes.</param>
        /// <param name="startDate">Windows IoT Device Service start
        /// date,</param>
        /// <param name="quantity">Windows IoT Device Service device
        /// allocation,</param>
        /// <param name="billingDomainName">Windows IoT Device Service ODM AAD
        /// domain</param>
        /// <param name="adminDomainName">Windows IoT Device Service OEM AAD
        /// domain</param>
        public DeviceService(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string etag = default(string), string notes = default(string), System.DateTime? startDate = default(System.DateTime?), long? quantity = default(long?), string billingDomainName = default(string), string adminDomainName = default(string))
            : base(id, name, type, tags, location)
        {
            Etag = etag;
            Notes = notes;
            StartDate = startDate;
            Quantity = quantity;
            BillingDomainName = billingDomainName;
            AdminDomainName = adminDomainName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Etag field is *not* required. If it is provided in
        /// the response body, it must also be provided as a header per the
        /// normal ETag convention.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets windows IoT Device Service notes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets windows IoT Device Service start date,
        /// </summary>
        [JsonProperty(PropertyName = "properties.startDate")]
        public System.DateTime? StartDate { get; private set; }

        /// <summary>
        /// Gets or sets windows IoT Device Service device allocation,
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Gets or sets windows IoT Device Service ODM AAD domain
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingDomainName")]
        public string BillingDomainName { get; set; }

        /// <summary>
        /// Gets or sets windows IoT Device Service OEM AAD domain
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminDomainName")]
        public string AdminDomainName { get; set; }

    }
}
