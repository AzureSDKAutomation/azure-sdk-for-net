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
    using System.Linq;

    /// <summary>
    /// Defines headers for CreateOrUpdate operation.
    /// </summary>
    public partial class MachineLearningServiceCreateOrUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MachineLearningServiceCreateOrUpdateHeaders class.
        /// </summary>
        public MachineLearningServiceCreateOrUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MachineLearningServiceCreateOrUpdateHeaders class.
        /// </summary>
        /// <param name="azureAsyncOperation">URI to poll for asynchronous
        /// operation status.</param>
        public MachineLearningServiceCreateOrUpdateHeaders(string azureAsyncOperation = default(string))
        {
            AzureAsyncOperation = azureAsyncOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URI to poll for asynchronous operation status.
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

    }
}
