// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The response model for the successful Stateset Create API.
    /// </summary>
    public partial class StatesetCreatedResponse
    {
        /// <summary>
        /// Initializes a new instance of the StatesetCreatedResponse class.
        /// </summary>
        public StatesetCreatedResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatesetCreatedResponse class.
        /// </summary>
        /// <param name="statesetId">The ID for the new stateset
        /// created.</param>
        public StatesetCreatedResponse(string statesetId = default(string))
        {
            StatesetId = statesetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID for the new stateset created.
        /// </summary>
        [JsonProperty(PropertyName = "statesetId")]
        public string StatesetId { get; private set; }

    }
}
