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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Trigger based on status code.
    /// </summary>
    public partial class StatusCodesBasedTrigger
    {
        /// <summary>
        /// Initializes a new instance of the StatusCodesBasedTrigger class.
        /// </summary>
        public StatusCodesBasedTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatusCodesBasedTrigger class.
        /// </summary>
        /// <param name="status">HTTP status code.</param>
        /// <param name="subStatus">Request Sub Status.</param>
        /// <param name="win32Status">Win32 error code.</param>
        /// <param name="path">Request Path</param>
        /// <param name="count">Request Count.</param>
        /// <param name="timeInterval">Time interval.</param>
        public StatusCodesBasedTrigger(int? status = default(int?), int? subStatus = default(int?), int? win32Status = default(int?), string path = default(string), int? count = default(int?), string timeInterval = default(string))
        {
            Status = status;
            SubStatus = subStatus;
            Win32Status = win32Status;
            Path = path;
            Count = count;
            TimeInterval = timeInterval;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets request Sub Status.
        /// </summary>
        [JsonProperty(PropertyName = "subStatus")]
        public int? SubStatus { get; set; }

        /// <summary>
        /// Gets or sets win32 error code.
        /// </summary>
        [JsonProperty(PropertyName = "win32Status")]
        public int? Win32Status { get; set; }

        /// <summary>
        /// Gets or sets request Path
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets request Count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets time interval.
        /// </summary>
        [JsonProperty(PropertyName = "timeInterval")]
        public string TimeInterval { get; set; }

    }
}
