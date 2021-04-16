// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Quota update parameters.
    /// </summary>
    public partial class QuotaUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the QuotaUpdateParameters class.
        /// </summary>
        public QuotaUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaUpdateParameters class.
        /// </summary>
        /// <param name="value">The list for update quota.</param>
        /// <param name="location">Region of workspace quota to be
        /// updated.</param>
        public QuotaUpdateParameters(IList<QuotaBaseProperties> value = default(IList<QuotaBaseProperties>), string location = default(string))
        {
            Value = value;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list for update quota.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<QuotaBaseProperties> Value { get; set; }

        /// <summary>
        /// Gets or sets region of workspace quota to be updated.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
