// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Automatic tuning properties for individual advisors.
    /// </summary>
    public partial class AutomaticTuningOptions
    {
        /// <summary>
        /// Initializes a new instance of the AutomaticTuningOptions class.
        /// </summary>
        public AutomaticTuningOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomaticTuningOptions class.
        /// </summary>
        /// <param name="desiredState">Automatic tuning option desired state.
        /// Possible values include: 'Off', 'On', 'Default'</param>
        /// <param name="actualState">Automatic tuning option actual state.
        /// Possible values include: 'Off', 'On'</param>
        /// <param name="reasonCode">Reason code if desired and actual state
        /// are different.</param>
        /// <param name="reasonDesc">Reason description if desired and actual
        /// state are different. Possible values include: 'Default',
        /// 'Disabled', 'AutoConfigured', 'InheritedFromServer',
        /// 'QueryStoreOff', 'QueryStoreReadOnly', 'NotSupported'</param>
        public AutomaticTuningOptions(AutomaticTuningOptionModeDesired? desiredState = default(AutomaticTuningOptionModeDesired?), AutomaticTuningOptionModeActual? actualState = default(AutomaticTuningOptionModeActual?), int? reasonCode = default(int?), AutomaticTuningDisabledReason? reasonDesc = default(AutomaticTuningDisabledReason?))
        {
            DesiredState = desiredState;
            ActualState = actualState;
            ReasonCode = reasonCode;
            ReasonDesc = reasonDesc;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets automatic tuning option desired state. Possible values
        /// include: 'Off', 'On', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "desiredState")]
        public AutomaticTuningOptionModeDesired? DesiredState { get; set; }

        /// <summary>
        /// Gets automatic tuning option actual state. Possible values include:
        /// 'Off', 'On'
        /// </summary>
        [JsonProperty(PropertyName = "actualState")]
        public AutomaticTuningOptionModeActual? ActualState { get; private set; }

        /// <summary>
        /// Gets reason code if desired and actual state are different.
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public int? ReasonCode { get; private set; }

        /// <summary>
        /// Gets reason description if desired and actual state are different.
        /// Possible values include: 'Default', 'Disabled', 'AutoConfigured',
        /// 'InheritedFromServer', 'QueryStoreOff', 'QueryStoreReadOnly',
        /// 'NotSupported'
        /// </summary>
        [JsonProperty(PropertyName = "reasonDesc")]
        public AutomaticTuningDisabledReason? ReasonDesc { get; private set; }

    }
}
