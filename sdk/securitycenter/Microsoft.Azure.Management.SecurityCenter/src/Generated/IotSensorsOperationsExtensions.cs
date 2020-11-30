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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IotSensorsOperations.
    /// </summary>
    public static partial class IotSensorsOperationsExtensions
    {
            /// <summary>
            /// List IoT sensors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            public static IotSensorsList List(this IIotSensorsOperations operations, string scope)
            {
                return operations.ListAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT sensors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotSensorsList> ListAsync(this IIotSensorsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get IoT sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            public static IotSensorsModel Get(this IIotSensorsOperations operations, string scope, string iotSensorName)
            {
                return operations.GetAsync(scope, iotSensorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get IoT sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotSensorsModel> GetAsync(this IIotSensorsOperations operations, string scope, string iotSensorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, iotSensorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update IoT sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='zone'>
            /// Display name of the IoT zone
            /// </param>
            public static IotSensorsModel CreateOrUpdate(this IIotSensorsOperations operations, string scope, string iotSensorName, string zone = default(string))
            {
                return operations.CreateOrUpdateAsync(scope, iotSensorName, zone).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update IoT sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='zone'>
            /// Display name of the IoT zone
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotSensorsModel> CreateOrUpdateAsync(this IIotSensorsOperations operations, string scope, string iotSensorName, string zone = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, iotSensorName, zone, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete IoT sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            public static void Delete(this IIotSensorsOperations operations, string scope, string iotSensorName)
            {
                operations.DeleteAsync(scope, iotSensorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete IoT sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIotSensorsOperations operations, string scope, string iotSensorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(scope, iotSensorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Download sensor activation file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            public static Stream DownloadActivation(this IIotSensorsOperations operations, string scope, string iotSensorName)
            {
                return operations.DownloadActivationAsync(scope, iotSensorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Download sensor activation file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> DownloadActivationAsync(this IIotSensorsOperations operations, string scope, string iotSensorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.DownloadActivationWithHttpMessagesAsync(scope, iotSensorName, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Download file for reset password of the sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='applianceId'>
            /// The appliance id of the sensor.
            /// </param>
            public static Stream DownloadResetPassword(this IIotSensorsOperations operations, string scope, string iotSensorName, string applianceId = default(string))
            {
                return operations.DownloadResetPasswordAsync(scope, iotSensorName, applianceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Download file for reset password of the sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query (IoT Hub, /providers/Microsoft.Devices/iotHubs/myHub)
            /// </param>
            /// <param name='iotSensorName'>
            /// Name of the IoT sensor
            /// </param>
            /// <param name='applianceId'>
            /// The appliance id of the sensor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> DownloadResetPasswordAsync(this IIotSensorsOperations operations, string scope, string iotSensorName, string applianceId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.DownloadResetPasswordWithHttpMessagesAsync(scope, iotSensorName, applianceId, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

    }
}
