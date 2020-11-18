// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage information about the data disks present in the custom image
    /// </summary>
    public partial class DataDiskStorageTypeInfoFragment
    {
        /// <summary>
        /// Initializes a new instance of the DataDiskStorageTypeInfoFragment
        /// class.
        /// </summary>
        public DataDiskStorageTypeInfoFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataDiskStorageTypeInfoFragment
        /// class.
        /// </summary>
        /// <param name="lun">Disk Lun</param>
        /// <param name="storageType">Disk Storage Type. Possible values
        /// include: 'Standard', 'Premium', 'StandardSSD'</param>
        public DataDiskStorageTypeInfoFragment(string lun = default(string), string storageType = default(string))
        {
            Lun = lun;
            StorageType = storageType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets disk Lun
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public string Lun { get; set; }

        /// <summary>
        /// Gets or sets disk Storage Type. Possible values include:
        /// 'Standard', 'Premium', 'StandardSSD'
        /// </summary>
        [JsonProperty(PropertyName = "storageType")]
        public string StorageType { get; set; }

    }
}
