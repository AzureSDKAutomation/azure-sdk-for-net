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

    /// <summary>
    /// Defines values for GeofenceMode.
    /// </summary>
    public static class GeofenceMode
    {
        /// <summary>
        /// Publish all the query results to Azure Maps account event
        /// subscription.
        /// </summary>
        public const string All = "All";
        /// <summary>
        /// Only publish result when user location is considered as crossing
        /// geofencing boarder.
        /// </summary>
        public const string EnterAndExit = "EnterAndExit";
    }
}
