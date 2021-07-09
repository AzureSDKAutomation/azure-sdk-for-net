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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AmlCompute update parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClusterUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpdateParameters class.
        /// </summary>
        public ClusterUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterUpdateParameters class.
        /// </summary>
        /// <param name="properties">Properties of ClusterUpdate</param>
        public ClusterUpdateParameters(ScaleSettingsInformation properties = default(ScaleSettingsInformation))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of ClusterUpdate
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties")]
        public ScaleSettingsInformation Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
