// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about a specific patch that was encountered during an
    /// installation action.
    /// </summary>
    public partial class PatchInstallationDetail
    {
        /// <summary>
        /// Initializes a new instance of the PatchInstallationDetail class.
        /// </summary>
        public PatchInstallationDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchInstallationDetail class.
        /// </summary>
        /// <param name="patchId">A unique identifier for the patch.</param>
        /// <param name="name">The friendly name of the patch.</param>
        /// <param name="version">The version string of the package. It may
        /// conform to Semantic Versioning. Only applies to Linux.</param>
        /// <param name="kbId">The KBID of the patch. Only applies to Windows
        /// patches.</param>
        /// <param name="classifications">The classification(s) of the patch as
        /// provided by the patch publisher.</param>
        /// <param name="installationState">The state of the patch after the
        /// installation operation completed. Possible values include:
        /// 'Unknown', 'Installed', 'Failed', 'Excluded', 'NotSelected',
        /// 'Pending'</param>
        public PatchInstallationDetail(string patchId = default(string), string name = default(string), string version = default(string), string kbId = default(string), IList<string> classifications = default(IList<string>), string installationState = default(string))
        {
            PatchId = patchId;
            Name = name;
            Version = version;
            KbId = kbId;
            Classifications = classifications;
            InstallationState = installationState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a unique identifier for the patch.
        /// </summary>
        [JsonProperty(PropertyName = "patchId")]
        public string PatchId { get; private set; }

        /// <summary>
        /// Gets the friendly name of the patch.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the version string of the package. It may conform to Semantic
        /// Versioning. Only applies to Linux.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the KBID of the patch. Only applies to Windows patches.
        /// </summary>
        [JsonProperty(PropertyName = "kbId")]
        public string KbId { get; private set; }

        /// <summary>
        /// Gets the classification(s) of the patch as provided by the patch
        /// publisher.
        /// </summary>
        [JsonProperty(PropertyName = "classifications")]
        public IList<string> Classifications { get; private set; }

        /// <summary>
        /// Gets the state of the patch after the installation operation
        /// completed. Possible values include: 'Unknown', 'Installed',
        /// 'Failed', 'Excluded', 'NotSelected', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "installationState")]
        public string InstallationState { get; private set; }

    }
}
