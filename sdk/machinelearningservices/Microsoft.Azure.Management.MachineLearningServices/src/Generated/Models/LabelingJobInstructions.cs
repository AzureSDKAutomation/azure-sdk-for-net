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
    /// Instructions for labeling job
    /// </summary>
    public partial class LabelingJobInstructions
    {
        /// <summary>
        /// Initializes a new instance of the LabelingJobInstructions class.
        /// </summary>
        public LabelingJobInstructions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabelingJobInstructions class.
        /// </summary>
        /// <param name="uri">The link to a page with detailed labeling
        /// instructions for labelers.</param>
        public LabelingJobInstructions(string uri = default(string))
        {
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the link to a page with detailed labeling instructions
        /// for labelers.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

    }
}
