// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.IoT.DeviceUpdate.Models;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class DeviceUpdateModelFactory
    {
        /// <summary> Initializes a new instance of Update. </summary>
        /// <param name="updateId"> Update identity. </param>
        /// <param name="updateType"> Update type. </param>
        /// <param name="installedCriteria"> String interpreted by Device Update client to determine if the update is installed on the device. </param>
        /// <param name="compatibility"> List of update compatibility information. </param>
        /// <param name="manifestVersion"> Schema version of manifest used to import the update. </param>
        /// <param name="importedDateTime"> Date and time in UTC when the update was imported. </param>
        /// <param name="createdDateTime"> Date and time in UTC when the update was created. </param>
        /// <param name="etag"> Update ETag. </param>
        /// <returns> A new <see cref="Models.Update"/> instance for mocking. </returns>
        public static Update Update(UpdateId updateId = null, string updateType = null, string installedCriteria = null, IEnumerable<Compatibility> compatibility = null, string manifestVersion = null, DateTimeOffset importedDateTime = default, DateTimeOffset createdDateTime = default, string etag = null)
        {
            compatibility ??= new List<Compatibility>();

            return new Update(updateId, updateType, installedCriteria, compatibility?.ToList(), manifestVersion, importedDateTime, createdDateTime, etag);
        }

        /// <summary> Initializes a new instance of Compatibility. </summary>
        /// <param name="deviceManufacturer"> The manufacturer of device the update is compatible with. </param>
        /// <param name="deviceModel"> The model of device the update is compatible with. </param>
        /// <returns> A new <see cref="Models.Compatibility"/> instance for mocking. </returns>
        public static Compatibility Compatibility(string deviceManufacturer = null, string deviceModel = null)
        {
            return new Compatibility(deviceManufacturer, deviceModel);
        }

        /// <summary> Initializes a new instance of File. </summary>
        /// <param name="fileId"> File identity, generated by server at import time. </param>
        /// <param name="fileName"> File name. </param>
        /// <param name="sizeInBytes"> File size in number of bytes. </param>
        /// <param name="hashes"> Mapping of hashing algorithm to base64 encoded hash values. </param>
        /// <param name="mimeType"> File MIME type. </param>
        /// <param name="etag"> File ETag. </param>
        /// <returns> A new <see cref="Models.File"/> instance for mocking. </returns>
        public static File File(string fileId = null, string fileName = null, long sizeInBytes = default, IReadOnlyDictionary<string, string> hashes = null, string mimeType = null, string etag = null)
        {
            hashes ??= new Dictionary<string, string>();

            return new File(fileId, fileName, sizeInBytes, hashes, mimeType, etag);
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="updateId"> The identity of update being imported or deleted. For import, this property will only be populated after import manifest is processed successfully. </param>
        /// <param name="resourceLocation"> Location of the imported update when operation is successful. </param>
        /// <param name="error"> Operation error encountered, if any. </param>
        /// <param name="traceId"> Operation correlation identity that can used by Microsoft Support for troubleshooting. </param>
        /// <param name="lastActionDateTime"> Date and time in UTC when the operation status was last updated. </param>
        /// <param name="createdDateTime"> Date and time in UTC when the operation was created. </param>
        /// <param name="etag"> Operation ETag. </param>
        /// <returns> A new <see cref="Models.Operation"/> instance for mocking. </returns>
        public static Models.Operation Operation(string operationId = null, OperationStatus status = default, UpdateId updateId = null, string resourceLocation = null, Error error = null, string traceId = null, DateTimeOffset lastActionDateTime = default, DateTimeOffset createdDateTime = default, string etag = null)
        {
            return new Models.Operation(operationId, status, updateId, resourceLocation, error, traceId, lastActionDateTime, createdDateTime, etag);
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Server defined error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="target"> The target of the error. </param>
        /// <param name="details"> An array of errors that led to the reported error. </param>
        /// <param name="innererror"> An object containing more specific information than the current object about the error. </param>
        /// <param name="occurredDateTime"> Date and time in UTC when the error occurred. </param>
        /// <returns> A new <see cref="Models.Error"/> instance for mocking. </returns>
        public static Error Error(string code = null, string message = null, string target = null, IEnumerable<Error> details = null, InnerError innererror = null, DateTimeOffset? occurredDateTime = null)
        {
            details ??= new List<Error>();

            return new Error(code, message, target, details?.ToList(), innererror, occurredDateTime);
        }

        /// <summary> Initializes a new instance of InnerError. </summary>
        /// <param name="code"> A more specific error code than what was provided by the containing error. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="errorDetail"> The internal error or exception message. </param>
        /// <param name="innerErrorValue"> An object containing more specific information than the current object about the error. </param>
        /// <returns> A new <see cref="Models.InnerError"/> instance for mocking. </returns>
        public static InnerError InnerError(string code = null, string message = null, string errorDetail = null, InnerError innerErrorValue = null)
        {
            return new InnerError(code, message, errorDetail, innerErrorValue);
        }

        /// <summary> Initializes a new instance of DeviceClass. </summary>
        /// <param name="deviceClassId"> The device class identifier. </param>
        /// <param name="manufacturer"> Device manufacturer. </param>
        /// <param name="model"> Device model. </param>
        /// <param name="bestCompatibleUpdateId"> Update identity. </param>
        /// <returns> A new <see cref="Models.DeviceClass"/> instance for mocking. </returns>
        public static DeviceClass DeviceClass(string deviceClassId = null, string manufacturer = null, string model = null, UpdateId bestCompatibleUpdateId = null)
        {
            return new DeviceClass(deviceClassId, manufacturer, model, bestCompatibleUpdateId);
        }

        /// <summary> Initializes a new instance of Device. </summary>
        /// <param name="deviceId"> Device identity. </param>
        /// <param name="deviceClassId"> Device class identity. </param>
        /// <param name="manufacturer"> Device manufacturer. </param>
        /// <param name="model"> Device model. </param>
        /// <param name="groupId"> Device group identity. </param>
        /// <param name="lastAttemptedUpdateId"> Update identity. </param>
        /// <param name="deploymentStatus"> State of the device in its last deployment. </param>
        /// <param name="installedUpdateId"> Update identity. </param>
        /// <param name="onLatestUpdate"> Boolean flag indicating whether the latest update is installed on the device. </param>
        /// <param name="lastDeploymentId"> The deployment identifier for the last deployment to the device. </param>
        /// <returns> A new <see cref="Models.Device"/> instance for mocking. </returns>
        public static Device Device(string deviceId = null, string deviceClassId = null, string manufacturer = null, string model = null, string groupId = null, UpdateId lastAttemptedUpdateId = null, DeviceDeploymentState? deploymentStatus = null, UpdateId installedUpdateId = null, bool onLatestUpdate = default, string lastDeploymentId = null)
        {
            return new Device(deviceId, deviceClassId, manufacturer, model, groupId, lastAttemptedUpdateId, deploymentStatus, installedUpdateId, onLatestUpdate, lastDeploymentId);
        }

        /// <summary> Initializes a new instance of UpdateCompliance. </summary>
        /// <param name="totalDeviceCount"> Total number of devices. </param>
        /// <param name="onLatestUpdateDeviceCount"> Number of devices on the latest update. </param>
        /// <param name="newUpdatesAvailableDeviceCount"> Number of devices with a newer update available. </param>
        /// <param name="updatesInProgressDeviceCount"> Number of devices with update in-progress. </param>
        /// <returns> A new <see cref="Models.UpdateCompliance"/> instance for mocking. </returns>
        public static UpdateCompliance UpdateCompliance(int totalDeviceCount = default, int onLatestUpdateDeviceCount = default, int newUpdatesAvailableDeviceCount = default, int updatesInProgressDeviceCount = default)
        {
            return new UpdateCompliance(totalDeviceCount, onLatestUpdateDeviceCount, newUpdatesAvailableDeviceCount, updatesInProgressDeviceCount);
        }

        /// <summary> Initializes a new instance of DeviceTag. </summary>
        /// <param name="tagName"> Tag name. </param>
        /// <param name="deviceCount"> Number of devices with this tag. </param>
        /// <returns> A new <see cref="Models.DeviceTag"/> instance for mocking. </returns>
        public static DeviceTag DeviceTag(string tagName = null, int deviceCount = default)
        {
            return new DeviceTag(tagName, deviceCount);
        }

        /// <summary> Initializes a new instance of UpdatableDevices. </summary>
        /// <param name="updateId"> Update identity. </param>
        /// <param name="deviceCount"> Total number of devices for which the update is applicable. </param>
        /// <returns> A new <see cref="Models.UpdatableDevices"/> instance for mocking. </returns>
        public static UpdatableDevices UpdatableDevices(UpdateId updateId = null, int deviceCount = default)
        {
            return new UpdatableDevices(updateId, deviceCount);
        }

        /// <summary> Initializes a new instance of DeploymentStatus. </summary>
        /// <param name="deploymentState"> Gets or sets the state of the deployment. </param>
        /// <param name="totalDevices"> Gets or sets the total number of devices in the deployment. </param>
        /// <param name="devicesIncompatibleCount"> Gets or sets the number of incompatible devices in the deployment. </param>
        /// <param name="devicesInProgressCount"> Gets or sets the number of devices that are currently in deployment. </param>
        /// <param name="devicesCompletedFailedCount"> Gets or sets the number of devices that have completed deployment with a failure. </param>
        /// <param name="devicesCompletedSucceededCount"> Gets or sets the number of devices which have successfully completed deployment. </param>
        /// <param name="devicesCanceledCount"> Gets or sets the number of devices which have had their deployment canceled. </param>
        /// <returns> A new <see cref="Models.DeploymentStatus"/> instance for mocking. </returns>
        public static DeploymentStatus DeploymentStatus(DeploymentState deploymentState = default, int? totalDevices = null, int? devicesIncompatibleCount = null, int? devicesInProgressCount = null, int? devicesCompletedFailedCount = null, int? devicesCompletedSucceededCount = null, int? devicesCanceledCount = null)
        {
            return new DeploymentStatus(deploymentState, totalDevices, devicesIncompatibleCount, devicesInProgressCount, devicesCompletedFailedCount, devicesCompletedSucceededCount, devicesCanceledCount);
        }

        /// <summary> Initializes a new instance of DeploymentDeviceState. </summary>
        /// <param name="deviceId"> Device identity. </param>
        /// <param name="retryCount"> The number of times this deployment has been retried on this device. </param>
        /// <param name="movedOnToNewDeployment"> Boolean flag indicating whether this device is in a newer deployment and can no longer retry this deployment. </param>
        /// <param name="deviceState"> Deployment device state. </param>
        /// <returns> A new <see cref="Models.DeploymentDeviceState"/> instance for mocking. </returns>
        public static DeploymentDeviceState DeploymentDeviceState(string deviceId = null, int retryCount = default, bool movedOnToNewDeployment = default, DeviceDeploymentState deviceState = default)
        {
            return new DeploymentDeviceState(deviceId, retryCount, movedOnToNewDeployment, deviceState);
        }
    }
}
