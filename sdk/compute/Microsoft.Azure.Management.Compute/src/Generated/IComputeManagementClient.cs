// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Compute Client
    /// </summary>
    public partial interface IComputeManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAvailabilitySetsOperations.
        /// </summary>
        IAvailabilitySetsOperations AvailabilitySets { get; }

        /// <summary>
        /// Gets the IProximityPlacementGroupsOperations.
        /// </summary>
        IProximityPlacementGroupsOperations ProximityPlacementGroups { get; }

        /// <summary>
        /// Gets the IDedicatedHostGroupsOperations.
        /// </summary>
        IDedicatedHostGroupsOperations DedicatedHostGroups { get; }

        /// <summary>
        /// Gets the IDedicatedHostsOperations.
        /// </summary>
        IDedicatedHostsOperations DedicatedHosts { get; }

        /// <summary>
        /// Gets the ISshPublicKeysOperations.
        /// </summary>
        ISshPublicKeysOperations SshPublicKeys { get; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionImagesOperations.
        /// </summary>
        IVirtualMachineExtensionImagesOperations VirtualMachineExtensionImages { get; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionsOperations.
        /// </summary>
        IVirtualMachineExtensionsOperations VirtualMachineExtensions { get; }

        /// <summary>
        /// Gets the IVirtualMachineImagesOperations.
        /// </summary>
        IVirtualMachineImagesOperations VirtualMachineImages { get; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        IUsageOperations Usage { get; }

        /// <summary>
        /// Gets the IVirtualMachinesOperations.
        /// </summary>
        IVirtualMachinesOperations VirtualMachines { get; }

        /// <summary>
        /// Gets the IVirtualMachineSizesOperations.
        /// </summary>
        IVirtualMachineSizesOperations VirtualMachineSizes { get; }

        /// <summary>
        /// Gets the IImagesOperations.
        /// </summary>
        IImagesOperations Images { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetsOperations.
        /// </summary>
        IVirtualMachineScaleSetsOperations VirtualMachineScaleSets { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetExtensionsOperations.
        /// </summary>
        IVirtualMachineScaleSetExtensionsOperations VirtualMachineScaleSetExtensions { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetRollingUpgradesOperations.
        /// </summary>
        IVirtualMachineScaleSetRollingUpgradesOperations VirtualMachineScaleSetRollingUpgrades { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetVMExtensionsOperations.
        /// </summary>
        IVirtualMachineScaleSetVMExtensionsOperations VirtualMachineScaleSetVMExtensions { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetVMsOperations.
        /// </summary>
        IVirtualMachineScaleSetVMsOperations VirtualMachineScaleSetVMs { get; }

        /// <summary>
        /// Gets the ILogAnalyticsOperations.
        /// </summary>
        ILogAnalyticsOperations LogAnalytics { get; }

        /// <summary>
        /// Gets the IVirtualMachineRunCommandsOperations.
        /// </summary>
        IVirtualMachineRunCommandsOperations VirtualMachineRunCommands { get; }

        /// <summary>
        /// Gets the IResourceSkusOperations.
        /// </summary>
        IResourceSkusOperations ResourceSkus { get; }

        /// <summary>
        /// Gets the IDisksOperations.
        /// </summary>
        IDisksOperations Disks { get; }

        /// <summary>
        /// Gets the ISnapshotsOperations.
        /// </summary>
        ISnapshotsOperations Snapshots { get; }

        /// <summary>
        /// Gets the IDiskEncryptionSetsOperations.
        /// </summary>
        IDiskEncryptionSetsOperations DiskEncryptionSets { get; }

        /// <summary>
        /// Gets the IDiskAccessesOperations.
        /// </summary>
        IDiskAccessesOperations DiskAccesses { get; }

        /// <summary>
        /// Gets the IGalleriesOperations.
        /// </summary>
        IGalleriesOperations Galleries { get; }

        /// <summary>
        /// Gets the IGalleryImagesOperations.
        /// </summary>
        IGalleryImagesOperations GalleryImages { get; }

        /// <summary>
        /// Gets the IGalleryImageVersionsOperations.
        /// </summary>
        IGalleryImageVersionsOperations GalleryImageVersions { get; }

        /// <summary>
        /// Gets the IGalleryApplicationsOperations.
        /// </summary>
        IGalleryApplicationsOperations GalleryApplications { get; }

        /// <summary>
        /// Gets the IGalleryApplicationVersionsOperations.
        /// </summary>
        IGalleryApplicationVersionsOperations GalleryApplicationVersions { get; }

        /// <summary>
        /// Gets the IContainerServicesOperations.
        /// </summary>
        IContainerServicesOperations ContainerServices { get; }

    }
}
