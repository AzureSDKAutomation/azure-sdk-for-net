// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeOrder.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Holds billing meter details for each type of billing
    /// </summary>
    public partial class BillingMeterDetails
    {
        /// <summary>
        /// Initializes a new instance of the BillingMeterDetails class.
        /// </summary>
        public BillingMeterDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingMeterDetails class.
        /// </summary>
        /// <param name="name">Represents Billing type name</param>
        /// <param name="meterDetails">Represents MeterDetails</param>
        /// <param name="meteringType">Represents Metering type (eg one-time or
        /// recurrent). Possible values include: 'OneTime', 'Recurring',
        /// 'Adhoc'</param>
        /// <param name="frequency">Frequency of recurrence</param>
        public BillingMeterDetails(string name = default(string), MeterDetails meterDetails = default(MeterDetails), string meteringType = default(string), string frequency = default(string))
        {
            Name = name;
            MeterDetails = meterDetails;
            MeteringType = meteringType;
            Frequency = frequency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets represents Billing type name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets represents MeterDetails
        /// </summary>
        [JsonProperty(PropertyName = "meterDetails")]
        public MeterDetails MeterDetails { get; private set; }

        /// <summary>
        /// Gets represents Metering type (eg one-time or recurrent). Possible
        /// values include: 'OneTime', 'Recurring', 'Adhoc'
        /// </summary>
        [JsonProperty(PropertyName = "meteringType")]
        public string MeteringType { get; private set; }

        /// <summary>
        /// Gets frequency of recurrence
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; private set; }

    }
}
