// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service.Models
{

    /// <summary>
    /// Defines values for MapTileLayer.
    /// </summary>
    public static class MapTileLayer
    {
        /// <summary>
        /// Returns a tile containing all map features including polygons,
        /// borders, roads and labels.
        /// </summary>
        public const string Basic = "basic";
        /// <summary>
        /// Returns a tile containing borders, roads, and labels, and can be
        /// overlaid on other tiles (such as satellite imagery) to produce
        /// hybrid tiles.
        /// </summary>
        public const string Hybrid = "hybrid";
        /// <summary>
        /// Returns a tile of just the map's label information.
        /// </summary>
        public const string Labels = "labels";
        /// <summary>
        /// Map canvas complete with shaded relief tiles. Zoom levels 0-6
        /// (inclusive) are supported. Png is the only supported TileFormat and
        /// only available MapTileSize is 512.
        /// </summary>
        public const string Terra = "terra";
    }
}
