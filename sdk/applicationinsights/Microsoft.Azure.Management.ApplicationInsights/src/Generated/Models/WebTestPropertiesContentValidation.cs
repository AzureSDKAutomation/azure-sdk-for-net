// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The collection of content validation properties
    /// </summary>
    public partial class WebTestPropertiesContentValidation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebTestPropertiesContentValidation class.
        /// </summary>
        public WebTestPropertiesContentValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebTestPropertiesContentValidation class.
        /// </summary>
        /// <param name="contentMatch">Content to look for in the return of the
        /// WebTest.</param>
        /// <param name="ignoreCase">When set, this value makes the
        /// ContentMatch validation case insensitive.</param>
        /// <param name="passIfTextFound">When true, validation will pass if
        /// there is a match for the ContentMatch string.  If false, validation
        /// will fail if there is a match</param>
        public WebTestPropertiesContentValidation(string contentMatch = default(string), bool? ignoreCase = default(bool?), bool? passIfTextFound = default(bool?))
        {
            ContentMatch = contentMatch;
            IgnoreCase = ignoreCase;
            PassIfTextFound = passIfTextFound;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content to look for in the return of the WebTest.
        /// </summary>
        [JsonProperty(PropertyName = "ContentMatch")]
        public string ContentMatch { get; set; }

        /// <summary>
        /// Gets or sets when set, this value makes the ContentMatch validation
        /// case insensitive.
        /// </summary>
        [JsonProperty(PropertyName = "IgnoreCase")]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// Gets or sets when true, validation will pass if there is a match
        /// for the ContentMatch string.  If false, validation will fail if
        /// there is a match
        /// </summary>
        [JsonProperty(PropertyName = "PassIfTextFound")]
        public bool? PassIfTextFound { get; set; }

    }
}
