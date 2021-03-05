// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.DeviceUpdate.Models
{
    /// <summary> Deployment device state filter. </summary>
    internal partial class DeploymentDeviceStatesFilter
    {
        /// <summary> Initializes a new instance of DeploymentDeviceStatesFilter. </summary>
        internal DeploymentDeviceStatesFilter()
        {
        }

        /// <summary> Device Identifier. </summary>
        public string DeviceId { get; }
        /// <summary> The deployment device state. </summary>
        public DeviceState? DeviceState { get; }
    }
}