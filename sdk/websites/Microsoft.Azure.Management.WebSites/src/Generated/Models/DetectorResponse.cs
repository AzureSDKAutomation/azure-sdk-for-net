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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing Response from Detector
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DetectorResponse : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DetectorResponse class.
        /// </summary>
        public DetectorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetectorResponse class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="metadata">metadata for the detector</param>
        /// <param name="dataset">Data Set</param>
        public DetectorResponse(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), DetectorInfo metadata = default(DetectorInfo), IList<DiagnosticData> dataset = default(IList<DiagnosticData>))
            : base(id, name, kind, type, systemData)
        {
            Metadata = metadata;
            Dataset = dataset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets metadata for the detector
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public DetectorInfo Metadata { get; set; }

        /// <summary>
        /// Gets or sets data Set
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataset")]
        public IList<DiagnosticData> Dataset { get; set; }

    }
}
