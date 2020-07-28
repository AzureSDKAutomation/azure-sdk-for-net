// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{

    /// <summary>
    /// Defines values for RollingUpgradeMode.
    /// </summary>
    public static class RollingUpgradeMode
    {
        /// <summary>
        /// Indicates the upgrade mode is invalid. All Service Fabric
        /// enumerations have the invalid type. The value is zero.
        /// </summary>
        public const string Invalid = "Invalid";
        /// <summary>
        /// The upgrade will proceed automatically without performing any
        /// health monitoring. The value is 1
        /// </summary>
        public const string UnmonitoredAuto = "UnmonitoredAuto";
        /// <summary>
        /// The upgrade will stop after completing each upgrade domain, giving
        /// the opportunity to manually monitor health before proceeding. The
        /// value is 2
        /// </summary>
        public const string UnmonitoredManual = "UnmonitoredManual";
        /// <summary>
        /// The upgrade will stop after completing each upgrade domain and
        /// automatically monitor health before proceeding. The value is 3
        /// </summary>
        public const string Monitored = "Monitored";
    }
}
