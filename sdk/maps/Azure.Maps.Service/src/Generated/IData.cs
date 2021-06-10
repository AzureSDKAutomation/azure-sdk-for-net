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
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Data operations.
    /// </summary>
    public partial interface IData
    {
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// The Data Upload API allows the caller to upload data content to the
        /// Azure Maps service.
        /// You can use this API in a scenario like uploading a collection of
        /// Geofences in `GeoJSON`
        /// format, for use in our [Azure Maps Geofencing
        /// Service](https://docs.microsoft.com/rest/api/maps/spatial).
        ///
        /// ## Submit Upload Request
        ///
        /// To upload your content you will use a `POST` request. The request
        /// body will contain the data to upload. The
        /// `dataFormat` query parameter will contain the format for the data,
        /// the `dataSharingLevel` query parameter
        /// can contain the sharing level for the data. The `Content-Type`
        /// header will be set to the content type of the
        /// data.
        ///
        /// For example, to upload a collection of geofences  in `GeoJSON`
        /// format, set the request body to the geofence
        /// content. Set the `dataFormat` query parameter to _geojson_, and set
        /// the `Content-Type` header to either one
        /// of the following media types:
        ///
        /// - `application/json`
        /// - `application/vnd.geo+json`
        /// - `application/octet-stream`
        ///
        /// Here's a sample request body for uploading a simple Geofence
        /// represented as a circle geometry using a center
        /// point and a radius. The sample below is in `GeoJSON`:
        ///
        /// ```json
        /// {
        /// "type": "FeatureCollection",
        /// "features": [{
        /// "type": "Feature",
        /// "geometry": {
        /// "type": "Point",
        /// "coordinates": [-122.126986, 47.639754]
        /// },
        /// "properties": {
        /// "geometryId": "001",
        /// "radius": 500
        /// }
        /// }]
        /// }
        /// ```
        ///
        /// The Data Upload API performs a
        /// [long-running request](https://aka.ms/am-creator-lrt-v2).
        ///
        /// ## Data Upload Limits
        ///
        /// Please, be aware that currently every Azure Maps account has a
        /// [data storage
        /// limit](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/azure-subscription-service-limits#azure-maps-limits).
        /// Once the storage limit is reached, all the new upload API calls
        /// will return a `409 Conflict` http error response.
        /// You can always use the [Data Delete
        /// API](https://docs.microsoft.com/rest/api/maps/data%20v2/deletepreview)
        /// to
        /// delete old/unused content and create space for new uploads.
        /// </summary>
        /// <param name='uploadDataFormat'>
        /// Data format of the content being uploaded. Possible values include:
        /// 'geojson', 'zip', 'dwgzippackage'
        /// </param>
        /// <param name='uploadContent'>
        /// The content to upload.
        /// </param>
        /// <param name='uploadDataDescription'>
        /// The description to be given to the upload.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LongRunningOperationResult,DataUploadPreviewHeaders>> UploadPreviewWithHttpMessagesAsync(string uploadDataFormat, object uploadContent, string uploadDataDescription = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// This API allows the caller to fetch a list of all content uploaded
        /// previously using the [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview).
        ///
        ///
        /// ### Submit List Request
        ///
        /// To list all your map data content you will issue a `GET` request
        /// with no additional parameters.
        ///
        ///
        /// ### List Data Response
        ///
        /// The Data List API returns the complete list of all data in `json`
        /// format. The response contains the following details for each data
        /// resource:
        ///
        /// &gt; udid - The unique data id for the data resource.
        ///
        /// &gt; location - The location of the data resource. Execute a HTTP
        /// `GET` on this location to download the data.
        ///
        ///
        /// Here's a sample response returning the `udid` and `location` of 3
        /// data resources:
        ///
        /// &lt;br&gt;
        ///
        /// ```json
        /// {
        /// "mapDataList":
        /// [
        /// {
        /// "udid": "9a1288fa-1858-4a3b-b68d-13a8j5af7d7c",
        /// "location":
        /// "https://us.atlas.microsoft.com/mapData/9a1288fa-1858-4a3b-b68d-13a8j5af7d7c?api-version=1.0",
        /// "sizeInBytes": 29920,
        /// "uploadStatus": "Completed"
        /// },
        /// {
        /// "udid": "8b1288fa-1958-4a2b-b68e-13a7i5af7d7c",
        /// "location":
        /// "https://us.atlas.microsoft.com/mapData/8b1288fa-1958-4a2b-b68e-13a7i5af7d7c?api-version=1.0",
        /// "sizeInBytes": 1339,
        /// "uploadStatus": "Completed"
        /// },
        /// {
        /// "udid": "7c1288fa-2058-4a1b-b68f-13a6h5af7d7c",
        /// "location":
        /// "https://us.atlas.microsoft.com/mapData/7c1288fa-2058-4a1b-b68f-13a6h5af7d7c?api-version=1.0",
        /// "sizeInBytes": 1650,
        /// "uploadStatus": "Pending"
        /// }]
        /// }
        /// ```
        ///
        /// &lt;br&gt;
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<MapDataListResponse>> ListPreviewWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// The Data Update API allows the caller to update a previously
        /// uploaded data content.
        ///
        /// You can use this API in a scenario like adding or removing
        /// geofences to or from an existing collection of geofences.
        /// Geofences are uploaded using the [Data Upload
        /// API](https://docs.microsoft.com/rest/api/maps/data%20v2/uploadpreview),
        /// for
        /// use in the [Azure Maps Geofencing
        /// Service](https://docs.microsoft.com/rest/api/maps/spatial).
        ///
        /// Please note that the Update API will *replace* and *override* the
        /// existing data content.
        ///
        /// ## Submit Update Request
        ///
        /// To update your content you will use a `PUT` request. The request
        /// body will contain the new data that will replace
        /// the existing data. The `Content-Type` header will be set to the
        /// content type of the data, and the path will contain
        /// the `udid` of the data to be update.
        ///
        /// For example, to update a collection of geofences that were
        /// previously uploaded using the Upload API, place the new
        /// geofence content in the request body. Set the `udid` parameter in
        /// the path to the `udid` of the data received
        /// previously in the upload API response. And set the `Content-Type`
        /// header to one of the following media types:
        ///
        /// - `application/json`
        /// - `application/vnd.geo+json`
        /// - `application/octet-stream`
        ///
        /// Here's a sample request body for updating a simple Geofence. It's
        /// represented as a circle geometry using a center
        /// point and a radius. The sample below is in `GeoJSON`:
        ///
        /// ```json
        /// {
        /// "type": "FeatureCollection",
        /// "features": [{
        /// "type": "Feature",
        /// "geometry": {
        /// "type": "Point",
        /// "coordinates": [-122.126986, 47.639754]
        /// },
        /// "properties": {
        /// "geometryId": "001",
        /// "radius": 500
        /// }
        /// }]
        /// }
        /// ```
        ///
        /// The previously uploaded geofence had a radius of 100m. The above
        /// request will update it to 500m.
        ///
        /// The Data Update API performs a
        /// [long-running request](https://aka.ms/am-creator-lrt-v2).
        ///
        /// ## Data Update Limits
        ///
        /// Please, be aware that currently every Azure Maps account has a
        /// [data storage
        /// limit](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/azure-subscription-service-limits#azure-maps-limits).
        /// Once the storage limit is reached, all the new upload API calls
        /// will return a `409 Conflict` http error response.
        /// You can always use the [Data Delete
        /// API](https://docs.microsoft.com/rest/api/maps/data%20v2/deletepreview)
        /// to
        /// delete old/unused content and create space for new uploads.
        /// </summary>
        /// <param name='uniqueDataId'>
        /// The unique data id for the content. The `udid` must have been
        /// obtained from a successful [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview)
        /// call.
        /// </param>
        /// <param name='updateContent'>
        /// The new content that will update/replace the previously uploaded
        /// content.
        /// </param>
        /// <param name='uploadDataDescription'>
        /// The description to be given to the upload.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LongRunningOperationResult,DataUpdatePreviewHeaders>> UpdatePreviewWithHttpMessagesAsync(string uniqueDataId, object updateContent, string uploadDataDescription = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// This API allows the caller to download a previously uploaded data
        /// content.&lt;br&gt;
        /// You can use this API in a scenario like downloading an existing
        /// collection of geofences uploaded previously using the [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview)
        /// for use in our [Azure Maps Geofencing
        /// Service](https://docs.microsoft.com/en-us/rest/api/maps/spatial).
        ///
        ///
        /// ### Submit Download Request
        ///
        /// To download your content you will use a `GET` request where the
        /// path will contain the `udid` of the data to download. Optionally,
        /// you can also pass in an `Accept` header to specify a preference for
        /// the `Content-Type` of the data response. &lt;br&gt;
        /// For example, to download a collection of geofences previously
        /// uploaded using the Upload API, set the `udid` parameter in the path
        /// to the `udid` of the data received previously in the upload API
        /// response and set the `Accept` header to either one of the following
        /// media types:
        ///
        /// - `application/json`
        /// - `application/vnd.geo+json`
        /// - `application/octet-stream`
        ///
        ///
        /// ### Download Data Response
        ///
        /// The Download API will return a HTTP `200 OK` response if the data
        /// resource with the passed-in `udid` is found, where the response
        /// body will contain the content of the data resource.&lt;br&gt;
        /// A HTTP `400 Bad Request` error response will be returned if the
        /// data resource with the passed-in `udid` is not found.&lt;br&gt;
        ///
        /// Here's a sample response body for a simple geofence represented in
        /// `GeoJSON` uploaded previously using the Upload API:
        /// &lt;br&gt;
        ///
        /// ```json
        /// {
        /// "type": "FeatureCollection",
        /// "features": [{
        /// "type": "Feature",
        /// "geometry": {
        /// "type": "Point",
        /// "coordinates": [-122.126986, 47.639754]
        /// },
        /// "properties": {
        /// "geometryId": "001",
        /// "radius": 500
        /// }
        /// }]
        /// }
        /// ```
        /// </summary>
        /// <param name='uniqueDataId'>
        /// The unique data id for the content. The `udid` must have been
        /// obtained from a successful [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview)
        /// call.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Stream,DataDownloadPreviewHeaders>> DownloadPreviewWithHttpMessagesAsync(string uniqueDataId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// This API allows the caller to delete a previously uploaded data
        /// content.&lt;br&gt;
        /// You can use this API in a scenario like removing geofences
        /// previously uploaded using the [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview)
        /// for use in our [Azure Maps Geofencing
        /// Service](https://docs.microsoft.com/en-us/rest/api/maps/spatial).
        /// You can also use this API to delete old/unused uploaded content and
        /// create space for new content.
        ///
        ///
        /// ### Submit Delete Request
        ///
        /// To delete your content you will issue a `DELETE` request where the
        /// path will contain the `udid` of the data to delete.&lt;br&gt;
        /// For example, to delete a collection of geofences previously
        /// uploaded using the Upload API, set the `udid` parameter in the path
        /// to the `udid` of the data received previously in the upload API
        /// response.
        ///
        ///
        /// ### Delete Data Response
        ///
        /// The Data Delete API returns a HTTP `204 No Content` response with
        /// an empty body, if the data resource was deleted
        /// successfully.&lt;br&gt;
        /// A HTTP `400 Bad Request` error response will be returned if the
        /// data resource with the passed-in `udid` is not found.
        /// </summary>
        /// <param name='uniqueDataId'>
        /// The unique data id for the content. The `udid` must have been
        /// obtained from a successful [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview)
        /// call.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeletePreviewWithHttpMessagesAsync(string uniqueDataId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This path will be obtained from a call to POST /mapData.  While in
        /// progress, an http200 will be returned with no extra headers -
        /// followed by an http200 with Resource-Location header once
        /// completed.
        /// </summary>
        /// <param name='operationId'>
        /// The ID to query the status for the data upload request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LongRunningOperationResult,DataGetOperationPreviewHeaders>> GetOperationPreviewWithHttpMessagesAsync(string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
