// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response model for the Dataset List API. The response body will
    /// contain a list of all the previously created datasets.
    /// </summary>
    public partial class DatasetListResponse
    {
        /// <summary>
        /// Initializes a new instance of the DatasetListResponse class.
        /// </summary>
        public DatasetListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetListResponse class.
        /// </summary>
        /// <param name="datasets">A list of all the previously created
        /// datasets.</param>
        /// <param name="nextLink">If present, the location of the next page of
        /// data.</param>
        public DatasetListResponse(IList<DatasetDetailInfo> datasets = default(IList<DatasetDetailInfo>), string nextLink = default(string))
        {
            Datasets = datasets;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of all the previously created datasets.
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<DatasetDetailInfo> Datasets { get; private set; }

        /// <summary>
        /// Gets if present, the location of the next page of data.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
