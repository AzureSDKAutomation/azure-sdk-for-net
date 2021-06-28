// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Databox Heavy Device Job Details
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxHeavy")]
    public partial class DataBoxHeavyJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxHeavyJobDetails class.
        /// </summary>
        public DataBoxHeavyJobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxHeavyJobDetails class.
        /// </summary>
        /// <param name="contactDetails">Contact details for notification and
        /// shipping.</param>
        /// <param name="jobStages">List of stages that run in the job.</param>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="deliveryPackage">Delivery package shipping
        /// details.</param>
        /// <param name="returnPackage">Return package shipping
        /// details.</param>
        /// <param name="dataImportDetails">Details of the data to be imported
        /// into azure.</param>
        /// <param name="dataExportDetails">Details of the data to be exported
        /// from azure.</param>
        /// <param name="preferences">Preferences for the order.</param>
        /// <param name="copyLogDetails">List of copy log details.</param>
        /// <param name="reverseShipmentLabelSasKey">Shared access key to
        /// download the return shipment label</param>
        /// <param name="chainOfCustodySasKey">Shared access key to download
        /// the chain of custody logs</param>
        /// <param name="keyEncryptionKey">Details about which key encryption
        /// type is being used.</param>
        /// <param name="expectedDataSizeInTeraBytes">The expected size of the
        /// data, which needs to be transferred in this job, in
        /// terabytes.</param>
        /// <param name="actions">Available actions on the job.</param>
        /// <param name="lastMitigationActionOnJob">Last mitigation action
        /// performed on the job.</param>
        /// <param name="copyProgress">Copy progress per account.</param>
        /// <param name="devicePassword">Set Device password for unlocking
        /// Databox Heavy. Should not be passed for
        /// TransferType:ExportFromAzure jobs. If this is not passed, the
        /// service will generate password itself. This will not be returned in
        /// Get Call. Password Requirements :  Password must be minimum of 12
        /// and maximum of 64 characters. Password must have at least one
        /// uppercase alphabet, one number and one special character. Password
        /// cannot have the following characters : IilLoO0 Password can have
        /// only alphabets, numbers and these characters :
        /// @#\-$%^!+=;:_()]+</param>
        public DataBoxHeavyJobDetails(ContactDetails contactDetails, IList<JobStages> jobStages = default(IList<JobStages>), ShippingAddress shippingAddress = default(ShippingAddress), PackageShippingDetails deliveryPackage = default(PackageShippingDetails), PackageShippingDetails returnPackage = default(PackageShippingDetails), IList<DataImportDetails> dataImportDetails = default(IList<DataImportDetails>), IList<DataExportDetails> dataExportDetails = default(IList<DataExportDetails>), Preferences preferences = default(Preferences), IList<CopyLogDetails> copyLogDetails = default(IList<CopyLogDetails>), string reverseShipmentLabelSasKey = default(string), string chainOfCustodySasKey = default(string), KeyEncryptionKey keyEncryptionKey = default(KeyEncryptionKey), int? expectedDataSizeInTeraBytes = default(int?), IList<CustomerResolutionCode?> actions = default(IList<CustomerResolutionCode?>), LastMitigationActionOnJob lastMitigationActionOnJob = default(LastMitigationActionOnJob), IList<CopyProgress> copyProgress = default(IList<CopyProgress>), string devicePassword = default(string))
            : base(contactDetails, jobStages, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, keyEncryptionKey, expectedDataSizeInTeraBytes, actions, lastMitigationActionOnJob)
        {
            CopyProgress = copyProgress;
            DevicePassword = devicePassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets copy progress per account.
        /// </summary>
        [JsonProperty(PropertyName = "copyProgress")]
        public IList<CopyProgress> CopyProgress { get; private set; }

        /// <summary>
        /// Gets or sets set Device password for unlocking Databox Heavy.
        /// Should not be passed for TransferType:ExportFromAzure jobs. If this
        /// is not passed, the service will generate password itself. This will
        /// not be returned in Get Call. Password Requirements :  Password must
        /// be minimum of 12 and maximum of 64 characters. Password must have
        /// at least one uppercase alphabet, one number and one special
        /// character. Password cannot have the following characters : IilLoO0
        /// Password can have only alphabets, numbers and these characters :
        /// @#\-$%^!+=;:_()]+
        /// </summary>
        [JsonProperty(PropertyName = "devicePassword")]
        public string DevicePassword { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
