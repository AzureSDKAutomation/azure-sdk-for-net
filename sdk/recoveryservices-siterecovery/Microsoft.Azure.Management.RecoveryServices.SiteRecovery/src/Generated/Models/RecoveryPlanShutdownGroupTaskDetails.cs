// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class represents the recovery plan shutdown group task details.
    /// </summary>
    public partial class RecoveryPlanShutdownGroupTaskDetails : GroupTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanShutdownGroupTaskDetails class.
        /// </summary>
        public RecoveryPlanShutdownGroupTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanShutdownGroupTaskDetails class.
        /// </summary>
        /// <param name="childTasks">The child tasks.</param>
        /// <param name="name">The name.</param>
        /// <param name="groupId">The group identifier.</param>
        /// <param name="rpGroupType">The group type.</param>
        public RecoveryPlanShutdownGroupTaskDetails(IList<ASRTask> childTasks = default(IList<ASRTask>), string name = default(string), string groupId = default(string), string rpGroupType = default(string))
            : base(childTasks)
        {
            Name = name;
            GroupId = groupId;
            RpGroupType = rpGroupType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the group identifier.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the group type.
        /// </summary>
        [JsonProperty(PropertyName = "rpGroupType")]
        public string RpGroupType { get; set; }

    }
}
