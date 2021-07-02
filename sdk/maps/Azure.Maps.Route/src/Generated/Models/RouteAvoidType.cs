// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Route.Models
{

    /// <summary>
    /// Defines values for RouteAvoidType.
    /// </summary>
    public static class RouteAvoidType
    {
        /// <summary>
        /// Avoids toll roads.
        /// </summary>
        public const string TollRoads = "tollRoads";
        /// <summary>
        /// Avoids motorways
        /// </summary>
        public const string Motorways = "motorways";
        /// <summary>
        /// Avoids ferries
        /// </summary>
        public const string Ferries = "ferries";
        /// <summary>
        /// Avoids unpaved roads
        /// </summary>
        public const string UnpavedRoads = "unpavedRoads";
        /// <summary>
        /// Avoids routes that require the use of carpool (HOV/High Occupancy
        /// Vehicle) lanes.
        /// </summary>
        public const string Carpools = "carpools";
        /// <summary>
        /// Avoids using the same road multiple times. Most useful in
        /// conjunction with `routeType`=thrilling.
        /// </summary>
        public const string AlreadyUsedRoads = "alreadyUsedRoads";
        /// <summary>
        /// Avoids border crossings in route calculation.
        /// </summary>
        public const string BorderCrossings = "borderCrossings";
    }
}
