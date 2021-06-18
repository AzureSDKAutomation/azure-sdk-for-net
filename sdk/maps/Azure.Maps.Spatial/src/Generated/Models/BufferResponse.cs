// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Spatial.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Spatial Buffer call.
    /// </summary>
    public partial class BufferResponse
    {
        /// <summary>
        /// Initializes a new instance of the BufferResponse class.
        /// </summary>
        public BufferResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BufferResponse class.
        /// </summary>
        /// <param name="summary">Summary of the call.</param>
        /// <param name="result">The FeatureCollection of buffers for the
        /// input.</param>
        public BufferResponse(BufferResponseSummary summary = default(BufferResponseSummary), GeoJsonFeatureCollection result = default(GeoJsonFeatureCollection))
        {
            Summary = summary;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets summary of the call.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public BufferResponseSummary Summary { get; private set; }

        /// <summary>
        /// Gets or sets the FeatureCollection of buffers for the input.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public GeoJsonFeatureCollection Result { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Result != null)
            {
                Result.Validate();
            }
        }
    }
}
