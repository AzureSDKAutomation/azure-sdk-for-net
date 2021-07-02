// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Weather.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The latest status on the alert in the current area.
    /// </summary>
    public partial class LatestStatus
    {
        /// <summary>
        /// Initializes a new instance of the LatestStatus class.
        /// </summary>
        public LatestStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LatestStatus class.
        /// </summary>
        /// <param name="localized">The latest status keyword for the alert, in
        /// the specified language. By default, returned in English
        /// (en-US).</param>
        /// <param name="english">Latest status keyword for the alert, in
        /// English (en-US). Possible values include: 'New', 'Extend',
        /// 'Cancel', 'Correct', 'Expire', 'Upgrade', 'Continue',
        /// 'Update'</param>
        public LatestStatus(string localized = default(string), string english = default(string))
        {
            Localized = localized;
            English = english;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the latest status keyword for the alert, in the
        /// specified language. By default, returned in English (en-US).
        /// </summary>
        [JsonProperty(PropertyName = "localized")]
        public string Localized { get; set; }

        /// <summary>
        /// Gets or sets latest status keyword for the alert, in English
        /// (en-US). Possible values include: 'New', 'Extend', 'Cancel',
        /// 'Correct', 'Expire', 'Upgrade', 'Continue', 'Update'
        /// </summary>
        [JsonProperty(PropertyName = "english")]
        public string English { get; set; }

    }
}
