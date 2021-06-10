// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Traffic.
    /// </summary>
    public static partial class TrafficExtensions
    {
            /// <summary>
            /// __Traffic Flow Tile__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            /// The Azure Flow Tile API serves 256 x 256 pixel tiles showing traffic flow.
            /// All tiles use the same grid system. Because the traffic tiles use
            /// transparent images, they can be layered on top of map tiles to create a
            /// compound  display. The Flow tiles use colors to indicate either the speed
            /// of traffic on different road segments, or the difference between that speed
            /// and the free-flow speed on the road segment in question.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Desired format of the response. Possible values are png &amp; pbf. Possible
            /// values include: 'png', 'pbf'
            /// </param>
            /// <param name='style'>
            /// &lt;p&gt;The style to be used to render the tile.&lt;/p&gt;. Possible
            /// values include: 'absolute', 'relative', 'relative-delay',
            /// 'reduced-sensitivity'
            /// </param>
            /// <param name='zoom'>
            /// Zoom level for the desired tile. For _raster_ tiles, value must be in the
            /// range: 0-22 (inclusive). For _vector_ tiles, value must be in the range:
            /// 0-22 (inclusive).
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='xTileIndex'>
            /// X coordinate of the tile on zoom grid. Value must be in the range [0,
            /// 2&lt;sup&gt;`zoom`&lt;/sup&gt; -1].
            ///
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='yTileIndex'>
            /// Y coordinate of the tile on zoom grid. Value must be in the range [0,
            /// 2&lt;sup&gt;`zoom`&lt;/sup&gt; -1].
            ///
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='thickness'>
            /// The value of the width of the line representing traffic. This value is a
            /// multiplier and the accepted values range from 1 - 20. The default value is
            /// 10. This parameter is not valid when format is pbf.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetTrafficFlowTileAsync(this ITraffic operations, string format, string style, int zoom, int xTileIndex, int yTileIndex, int? thickness = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetTrafficFlowTileWithHttpMessagesAsync(format, style, zoom, xTileIndex, yTileIndex, thickness, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// __Traffic Flow Segment__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            /// This service provides information about the speeds and travel times of the
            /// road fragment closest to the given coordinates. It is designed to work
            /// alongside the Flow layer of the Render Service to support clickable  flow
            /// data visualizations. With this API, the client side can connect any place
            /// in the map with flow data on the  closest road and present it to the user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Desired format of the response. Value can be either _json_ or _xml_.
            /// Possible values include: 'json', 'xml'
            /// </param>
            /// <param name='style'>
            /// The style to be used to render the tile. Valid values are absolute which
            /// returns colors reflecting the absolute speed measured, relative which
            /// returns the speed relative to free-flow, Relative-delay which displays
            /// relative speeds only where they are different from the freeflow speeds.
            /// Possible values include: 'absolute', 'relative', 'relative-delay'
            /// </param>
            /// <param name='zoom'>
            /// Zoom level for the desired tile. Zoom value must be in the range: 0-22
            /// (inclusive).
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='query'>
            /// Coordinates of the point close to the road segment. They have to be
            /// comma-separated and calculated using EPSG4326 projection.
            /// </param>
            /// <param name='unit'>
            /// Unit of speed in KMPH or MPH. Possible values include: 'KMPH', 'MPH'
            /// </param>
            /// <param name='thickness'>
            /// The value of the width of the line representing traffic. This value is a
            /// multiplier and the accepted values range from 1 - 20. The default value is
            /// 10.
            /// </param>
            /// <param name='openLr'>
            /// Boolean on whether the response should include OpenLR code
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficFlowSegmentResult> GetTrafficFlowSegmentAsync(this ITraffic operations, string format, string style, int zoom, string query, string unit = default(string), int? thickness = default(int?), bool? openLr = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrafficFlowSegmentWithHttpMessagesAsync(format, style, zoom, query, unit, thickness, openLr, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Traffic Incident Tile__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            /// This service serves 256 x 256 pixel tiles showing traffic incidents. All
            /// tiles use the same grid system. Because the traffic tiles use transparent
            /// images, they can be layered on top of map tiles to create a compound
            /// display. Traffic tiles render graphics to indicate traffic on the roads in
            /// the specified area.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Desired format of the response. Possible values are png &amp; pbf. Possible
            /// values include: 'png', 'pbf'
            /// </param>
            /// <param name='style'>
            /// The style to be used to render the tile. This parameter is not valid when
            /// format is pbf. Possible values include: 's1', 's2', 's3', 'night'
            /// </param>
            /// <param name='zoom'>
            /// Zoom level for the desired tile. For _raster_ tiles, value must be in the
            /// range: 0-22 (inclusive). For _vector_ tiles, value must be in the range:
            /// 0-22 (inclusive).
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='xTileIndex'>
            /// X coordinate of the tile on zoom grid. Value must be in the range [0,
            /// 2&lt;sup&gt;`zoom`&lt;/sup&gt; -1].
            ///
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='yTileIndex'>
            /// Y coordinate of the tile on zoom grid. Value must be in the range [0,
            /// 2&lt;sup&gt;`zoom`&lt;/sup&gt; -1].
            ///
            /// Please see [Zoom Levels and Tile
            /// Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid)
            /// for details.
            /// </param>
            /// <param name='trafficState'>
            /// Reference value for the state of traffic at a particular time, obtained
            /// from the Viewport API call, trafficModelId attribute in trafficState field.
            /// It is updated every minute, and is valid for two minutes before it times
            /// out. Use -1 to  get the most recent traffic information. Default: most
            /// recent traffic information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetTrafficIncidentTileAsync(this ITraffic operations, string format, string style, int zoom, int xTileIndex, int yTileIndex, string trafficState = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetTrafficIncidentTileWithHttpMessagesAsync(format, style, zoom, xTileIndex, yTileIndex, trafficState, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// __Traffic Incident Detail__
            ///
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            /// This API provides information on traffic incidents inside a given bounding
            /// box, based on the current Traffic  Model ID. The Traffic Model ID is
            /// available to grant synchronization of data between calls and API's. The
            /// Traffic Model ID is a key value for determining the currency of traffic
            /// incidents. It is updated every minute,  and is valid for two minutes before
            /// it times out. It is used in rendering  [incident
            /// tiles](https://docs.microsoft.com/en-us/rest/api/maps/traffic/gettrafficincidenttile).
            /// It can be  obtained from the [Viewport
            /// API](https://docs.microsoft.com/en-us/rest/api/maps/traffic/gettrafficincidentviewport).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Desired format of the response. Value can be either _json_ or _xml_.
            /// Possible values include: 'json', 'xml'
            /// </param>
            /// <param name='style'>
            /// The style that will be used to render the tile in Traffic [Incident Tile
            /// API](https://docs.microsoft.com/en-us/rest/api/maps/traffic/gettrafficincidenttile).
            /// This will have an effect on the coordinates of traffic incidents in the
            /// reply. Possible values include: 's1', 's2', 's3', 'night'
            /// </param>
            /// <param name='boundingbox'>
            /// The `boundingbox` is represented by two value pairs describing it's corners
            /// (first pair for lower left corner and second for upper right). The pairs
            /// can either be specified using any of the `projection`'s specified below
            /// (e.g., _minY,minX,maxY,maxX_) or by two latitude-longitude pairs (e.g.,
            /// _minLat,minLon,maxLat,maxLon_).&lt;br&gt;&lt;br&gt;NOTE: If
            /// latitude/longitude pairs are used, then the `projection` parameter must be
            /// set to "EPSG4326".
            /// </param>
            /// <param name='boundingZoom'>
            /// Zoom level for desired tile. 0 to 22 for raster tiles, 0 through 22 for
            /// vector tiles
            /// </param>
            /// <param name='trafficmodelid'>
            /// Number referencing traffic model. This can be obtained from the [Viewport
            /// API](https://docs.microsoft.com/en-us/rest/api/maps/traffic/gettrafficincidentviewport).
            /// It is updated every minute, and is valid for two minutes before it times
            /// out. If the wrong Traffic Model ID is specified, the correct one will be
            /// returned by the interface. A value of -1 will always invoke the most recent
            /// traffic model
            /// </param>
            /// <param name='language'>
            /// [ISO 639-1 code](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) for
            /// the output language. Supported languages are ar, ca, cs, da, de, el, en,
            /// en-GB, en-US, es, et, fi, fr, he, hu, id, in*, it, lt, lv, nb, nl, no, pl,
            /// pt, ro, ru, sk, sv, th, tr, zh.
            ///
            /// Please refer to [Supported
            /// Languages](https://docs.microsoft.com/en-us/azure/azure-maps/supported-languages)
            /// for details. When invalid language code is provided response is returned in
            /// English. When incident cause or description does not have translation,
            /// English description is returned.
            /// </param>
            /// <param name='projection'>
            /// The projection used to specify the coordinates in the request and response.
            /// [EPSG900913](http://docs.openlayers.org/library/spherical_mercator.html)
            /// (default) or [EPSG4326](http://spatialreference.org/ref/epsg/4326/).
            /// Possible values include: 'EPSG900913', 'EPSG4326'
            /// </param>
            /// <param name='geometries'>
            /// The type of vector geometry added to incidents (returned in the &lt;v&gt;
            /// element of the response). Possible values include: 'original', 'shifted'
            /// </param>
            /// <param name='expandCluster'>
            /// Boolean to indicate whether to list all traffic incidents in a cluster
            /// separately
            /// </param>
            /// <param name='originalPosition'>
            /// Boolean on whether to return the original position of the incident
            /// (&lt;op&gt;) as well as the one shifted to the beginning of the traffic
            /// tube (&lt;op&gt;)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficIncidentDetailResult> GetTrafficIncidentDetailAsync(this ITraffic operations, string format, string style, string boundingbox, int boundingZoom, string trafficmodelid, string language = default(string), string projection = default(string), string geometries = default(string), bool? expandCluster = default(bool?), bool? originalPosition = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrafficIncidentDetailWithHttpMessagesAsync(format, style, boundingbox, boundingZoom, trafficmodelid, language, projection, geometries, expandCluster, originalPosition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Traffic Incident Viewport__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            /// This API returns legal and technical information for the viewport described
            /// in the request. It should be called  by client applications whenever the
            /// viewport changes (for instance, through zooming, panning, going to a
            /// location, or displaying a route). The request should contain the bounding
            /// box and zoom level of the viewport  whose information is needed. The return
            /// will contain map version information, as well as the current Traffic  Model
            /// ID and copyright IDs. The Traffic Model ID returned by the Viewport
            /// Description is used by other APIs to  retrieve last traffic information for
            /// further processing.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Desired format of the response. Value can be either _json_ or _xml_.
            /// Possible values include: 'json', 'xml'
            /// </param>
            /// <param name='boundingbox'>
            /// Bounding box of the map viewport in
            /// [EPSG900913](http://docs.openlayers.org/library/spherical_mercator.html)
            /// projection. The `boundingbox` is represented by two value pairs describing
            /// it's corners (first pair for lower left corner and second for upper right).
            /// All values should be separated by commas (e.g., _minY,minX,maxY,maxX_). The
            /// maximum size of the bounding box that can be passed is dependent on the
            /// requested zoom level. The width and height cannot exceed 4092 pixels when
            /// rendered on the given zoom level.&lt;br&gt;&lt;br&gt;NOTE: Bounding boxes
            /// that cross the 180° meridian require special treatment. For such boxes, the
            /// eastern _maxX_ value will be negative, and thus less than the _minX_ value
            /// west of the 180° meridian. To address that, the value 40075016.6855874
            /// should be added to the true _maxX_ value before it is passed in the
            /// request.
            /// </param>
            /// <param name='boundingzoom'>
            /// Zoom level of the map viewport. Used to determine whether the view can be
            /// zoomed in.
            /// </param>
            /// <param name='overviewbox'>
            /// Bounding box of the overview map in
            /// [EPSG900913](http://docs.openlayers.org/library/spherical_mercator.html)
            /// projection.&lt;br&gt;&lt;br&gt;Used in case the overview box/mini map has
            /// different copyright data than the main map. If there is no mini map, the
            /// same coordinates as `boundingBox` is used.
            /// </param>
            /// <param name='overviewzoom'>
            /// Zoom level of the overview map. If there is no mini map, use the same zoom
            /// level as boundingZoom.
            /// </param>
            /// <param name='copyright'>
            /// Determines what copyright information to return. When true the copyright
            /// text is returned; when false only the copyright index is returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficIncidentViewportResult> GetTrafficIncidentViewportAsync(this ITraffic operations, string format, string boundingbox, int boundingzoom, string overviewbox, int overviewzoom, bool? copyright = true, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrafficIncidentViewportWithHttpMessagesAsync(format, boundingbox, boundingzoom, overviewbox, overviewzoom, copyright, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
