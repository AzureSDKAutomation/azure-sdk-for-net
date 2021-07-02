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
    /// The geofencing geometry.
    /// </summary>
    public partial class GeofenceGeometry
    {
        /// <summary>
        /// Initializes a new instance of the GeofenceGeometry class.
        /// </summary>
        public GeofenceGeometry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeofenceGeometry class.
        /// </summary>
        /// <param name="deviceId">ID of the device.</param>
        /// <param name="udId">The unique id returned from [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data/uploadPreview)
        /// after uploading a valid GeoJSON FeatureCollection object. Please
        /// refer to  [RFC
        /// 7946](https://tools.ietf.org/html/rfc7946#section-3.3) for details.
        /// All the feature's properties should  contain `geometryId`, which is
        /// used for identifying the geometry and is case-sensitive.</param>
        /// <param name="geometryId">The unique id identifies a
        /// geometry.</param>
        /// <param name="distance">Distance from the coordinate to the closest
        /// border of the geofence. Positive means the  coordinate is outside
        /// of the geofence. If the coordinate is outside of the geofence, but
        /// more than the value of searchBuffer away from the closest geofence
        /// border, then the value is 999. Negative means the coordinate is
        /// inside of the geofence. If the coordinate is inside the polygon,
        /// but more than the value of searchBuffer away from the closest
        /// geofencing border, then the value is -999. A value of 999 means
        /// that there is great confidence the coordinate is well outside the
        /// geofence. A value of -999 means that there is great confidence the
        /// coordinate is well within the geofence.</param>
        /// <param name="nearestLat">Latitude of the nearest point of the
        /// geometry.</param>
        /// <param name="nearestLon">Longitude of the nearest point of the
        /// geometry.</param>
        /// <param name="nearestZ">Sea level in meter of the nearest point on
        /// the 2D extrusion geometry. This will only be presented in response
        /// when value is provided for 'zInMeter' in the request.</param>
        public GeofenceGeometry(string deviceId = default(string), string udId = default(string), string geometryId = default(string), double? distance = default(double?), double? nearestLat = default(double?), double? nearestLon = default(double?), double? nearestZ = default(double?))
        {
            DeviceId = deviceId;
            UdId = udId;
            GeometryId = geometryId;
            Distance = distance;
            NearestLat = nearestLat;
            NearestLon = nearestLon;
            NearestZ = nearestZ;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID of the device.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; private set; }

        /// <summary>
        /// Gets the unique id returned from [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data/uploadPreview)
        /// after uploading a valid GeoJSON FeatureCollection object. Please
        /// refer to  [RFC
        /// 7946](https://tools.ietf.org/html/rfc7946#section-3.3) for details.
        /// All the feature's properties should  contain `geometryId`, which is
        /// used for identifying the geometry and is case-sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "udId")]
        public string UdId { get; private set; }

        /// <summary>
        /// Gets the unique id identifies a geometry.
        /// </summary>
        [JsonProperty(PropertyName = "geometryId")]
        public string GeometryId { get; private set; }

        /// <summary>
        /// Gets distance from the coordinate to the closest border of the
        /// geofence. Positive means the  coordinate is outside of the
        /// geofence. If the coordinate is outside of the geofence, but more
        /// than the value of searchBuffer away from the closest geofence
        /// border, then the value is 999. Negative means the coordinate is
        /// inside of the geofence. If the coordinate is inside the polygon,
        /// but more than the value of searchBuffer away from the closest
        /// geofencing border, then the value is -999. A value of 999 means
        /// that there is great confidence the coordinate is well outside the
        /// geofence. A value of -999 means that there is great confidence the
        /// coordinate is well within the geofence.
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public double? Distance { get; private set; }

        /// <summary>
        /// Gets latitude of the nearest point of the geometry.
        /// </summary>
        [JsonProperty(PropertyName = "nearestLat")]
        public double? NearestLat { get; private set; }

        /// <summary>
        /// Gets longitude of the nearest point of the geometry.
        /// </summary>
        [JsonProperty(PropertyName = "nearestLon")]
        public double? NearestLon { get; private set; }

        /// <summary>
        /// Gets sea level in meter of the nearest point on the 2D extrusion
        /// geometry. This will only be presented in response when value is
        /// provided for 'zInMeter' in the request.
        /// </summary>
        [JsonProperty(PropertyName = "nearestZ")]
        public double? NearestZ { get; private set; }

    }
}
