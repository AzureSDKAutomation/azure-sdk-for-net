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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the capacity reservation group that the
    /// capacity reservations should be assigned to. &lt;br&gt;&lt;br&gt;
    /// Currently, a capacity reservation can only be added to a capacity
    /// reservation group at creation time. An existing capacity reservation
    /// cannot be added or moved to another capacity reservation group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CapacityReservationGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CapacityReservationGroup class.
        /// </summary>
        public CapacityReservationGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityReservationGroup class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="capacityReservations">A list of all capacity
        /// reservation resource ids that belong to capacity reservation
        /// group.</param>
        /// <param name="virtualMachinesAssociated">A list of references to all
        /// virtual machines associated to the capacity reservation
        /// group.</param>
        /// <param name="instanceView">The capacity reservation group instance
        /// view which has the list of instance views for all the capacity
        /// reservations that belong to the capacity reservation group.</param>
        /// <param name="zones">Availability Zones to use for this capacity
        /// reservation group. The zones can be assigned only during creation.
        /// If not provided, the group supports only regional resources in the
        /// region. If provided, enforces each capacity reservation in the
        /// group to be in one of the zones.</param>
        public CapacityReservationGroup(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<SubResourceReadOnly> capacityReservations = default(IList<SubResourceReadOnly>), IList<SubResourceReadOnly> virtualMachinesAssociated = default(IList<SubResourceReadOnly>), CapacityReservationGroupInstanceView instanceView = default(CapacityReservationGroupInstanceView), IList<string> zones = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            CapacityReservations = capacityReservations;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            InstanceView = instanceView;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of all capacity reservation resource ids that belong to
        /// capacity reservation group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacityReservations")]
        public IList<SubResourceReadOnly> CapacityReservations { get; private set; }

        /// <summary>
        /// Gets a list of references to all virtual machines associated to the
        /// capacity reservation group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachinesAssociated")]
        public IList<SubResourceReadOnly> VirtualMachinesAssociated { get; private set; }

        /// <summary>
        /// Gets the capacity reservation group instance view which has the
        /// list of instance views for all the capacity reservations that
        /// belong to the capacity reservation group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public CapacityReservationGroupInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets availability Zones to use for this capacity
        /// reservation group. The zones can be assigned only during creation.
        /// If not provided, the group supports only regional resources in the
        /// region. If provided, enforces each capacity reservation in the
        /// group to be in one of the zones.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
