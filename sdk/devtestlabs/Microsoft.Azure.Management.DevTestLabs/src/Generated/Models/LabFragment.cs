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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A lab.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LabFragment : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the LabFragment class.
        /// </summary>
        public LabFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabFragment class.
        /// </summary>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="labStorageType">Type of storage used by the lab. It
        /// can be either Premium or Standard. Default is Premium. Possible
        /// values include: 'Standard', 'Premium', 'StandardSSD'</param>
        /// <param name="mandatoryArtifactsResourceIdsLinux">The ordered list
        /// of artifact resource IDs that should be applied on all Linux VM
        /// creations by default, prior to the artifacts specified by the
        /// user.</param>
        /// <param name="mandatoryArtifactsResourceIdsWindows">The ordered list
        /// of artifact resource IDs that should be applied on all Windows VM
        /// creations by default, prior to the artifacts specified by the
        /// user.</param>
        /// <param name="premiumDataDisks">The setting to enable usage of
        /// premium data disks.
        /// When its value is 'Enabled', creation of standard or premium data
        /// disks is allowed.
        /// When its value is 'Disabled', only creation of standard data disks
        /// is allowed. Possible values include: 'Disabled', 'Enabled'</param>
        /// <param name="environmentPermission">The access rights to be granted
        /// to the user when provisioning an environment. Possible values
        /// include: 'Reader', 'Contributor'</param>
        /// <param name="announcement">The properties of any lab announcement
        /// associated with this lab</param>
        /// <param name="support">The properties of any lab support message
        /// associated with this lab</param>
        /// <param name="extendedProperties">Extended properties of the lab
        /// used for experimental features</param>
        public LabFragment(IDictionary<string, string> tags = default(IDictionary<string, string>), string labStorageType = default(string), IList<string> mandatoryArtifactsResourceIdsLinux = default(IList<string>), IList<string> mandatoryArtifactsResourceIdsWindows = default(IList<string>), string premiumDataDisks = default(string), string environmentPermission = default(string), LabAnnouncementPropertiesFragment announcement = default(LabAnnouncementPropertiesFragment), LabSupportPropertiesFragment support = default(LabSupportPropertiesFragment), IDictionary<string, string> extendedProperties = default(IDictionary<string, string>))
            : base(tags)
        {
            LabStorageType = labStorageType;
            MandatoryArtifactsResourceIdsLinux = mandatoryArtifactsResourceIdsLinux;
            MandatoryArtifactsResourceIdsWindows = mandatoryArtifactsResourceIdsWindows;
            PremiumDataDisks = premiumDataDisks;
            EnvironmentPermission = environmentPermission;
            Announcement = announcement;
            Support = support;
            ExtendedProperties = extendedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of storage used by the lab. It can be either
        /// Premium or Standard. Default is Premium. Possible values include:
        /// 'Standard', 'Premium', 'StandardSSD'
        /// </summary>
        [JsonProperty(PropertyName = "properties.labStorageType")]
        public string LabStorageType { get; set; }

        /// <summary>
        /// Gets or sets the ordered list of artifact resource IDs that should
        /// be applied on all Linux VM creations by default, prior to the
        /// artifacts specified by the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mandatoryArtifactsResourceIdsLinux")]
        public IList<string> MandatoryArtifactsResourceIdsLinux { get; set; }

        /// <summary>
        /// Gets or sets the ordered list of artifact resource IDs that should
        /// be applied on all Windows VM creations by default, prior to the
        /// artifacts specified by the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mandatoryArtifactsResourceIdsWindows")]
        public IList<string> MandatoryArtifactsResourceIdsWindows { get; set; }

        /// <summary>
        /// Gets or sets the setting to enable usage of premium data disks.
        /// When its value is 'Enabled', creation of standard or premium data
        /// disks is allowed.
        /// When its value is 'Disabled', only creation of standard data disks
        /// is allowed. Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.premiumDataDisks")]
        public string PremiumDataDisks { get; set; }

        /// <summary>
        /// Gets or sets the access rights to be granted to the user when
        /// provisioning an environment. Possible values include: 'Reader',
        /// 'Contributor'
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentPermission")]
        public string EnvironmentPermission { get; set; }

        /// <summary>
        /// Gets or sets the properties of any lab announcement associated with
        /// this lab
        /// </summary>
        [JsonProperty(PropertyName = "properties.announcement")]
        public LabAnnouncementPropertiesFragment Announcement { get; set; }

        /// <summary>
        /// Gets or sets the properties of any lab support message associated
        /// with this lab
        /// </summary>
        [JsonProperty(PropertyName = "properties.support")]
        public LabSupportPropertiesFragment Support { get; set; }

        /// <summary>
        /// Gets or sets extended properties of the lab used for experimental
        /// features
        /// </summary>
        [JsonProperty(PropertyName = "properties.extendedProperties")]
        public IDictionary<string, string> ExtendedProperties { get; set; }

    }
}
