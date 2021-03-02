// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request payload used to update and existing Accounts.
    /// </summary>
    public partial class AccountUpdate : TagUpdate
    {
        /// <summary>
        /// Initializes a new instance of the AccountUpdate class.
        /// </summary>
        public AccountUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountUpdate class.
        /// </summary>
        /// <param name="tags">List of key value pairs that describe the
        /// resource. This will overwrite the existing tags.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        public AccountUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string))
            : base(tags)
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
