// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IotSensorsOperations operations.
    /// </summary>
    public partial interface IIotSensorsOperations
    {
        /// <summary>
        /// List IoT sensors
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IotSensorsList>> ListWithHttpMessagesAsync(string scope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get IoT sensor
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='iotSensorName'>
        /// Name of the IoT sensor
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IotSensorsModel>> GetWithHttpMessagesAsync(string scope, string iotSensorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update IoT sensor
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='iotSensorName'>
        /// Name of the IoT sensor
        /// </param>
        /// <param name='iotSensorsModel'>
        /// The IoT sensor model
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IotSensorsModel>> CreateOrUpdateWithHttpMessagesAsync(string scope, string iotSensorName, IotSensorsModel iotSensorsModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete IoT sensor
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='iotSensorName'>
        /// Name of the IoT sensor
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string scope, string iotSensorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Download sensor activation file
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='iotSensorName'>
        /// Name of the IoT sensor
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Stream>> DownloadActivationWithHttpMessagesAsync(string scope, string iotSensorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Download file for reset password of the sensor
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='iotSensorName'>
        /// Name of the IoT sensor
        /// </param>
        /// <param name='applianceId'>
        /// The appliance id of the sensor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Stream>> DownloadResetPasswordWithHttpMessagesAsync(string scope, string iotSensorName, string applianceId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Trigger threat intelligence package update
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query (IoT Hub,
        /// /providers/Microsoft.Devices/iotHubs/myHub)
        /// </param>
        /// <param name='iotSensorName'>
        /// Name of the IoT sensor
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> TriggerTiPackageUpdateWithHttpMessagesAsync(string scope, string iotSensorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
