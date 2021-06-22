// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeOrder.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents order item contract
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OrderItemResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the OrderItemResource class.
        /// </summary>
        public OrderItemResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderItemResource class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="orderItemDetails">Represents order item
        /// details.</param>
        /// <param name="addressDetails">Represents shipping and return address
        /// for order item</param>
        /// <param name="orderId">Id of the order to which order item belongs
        /// to</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="startTime">Start time of order item</param>
        /// <param name="systemData">Represents resource creation and update
        /// time</param>
        public OrderItemResource(string location, OrderItemDetails orderItemDetails, AddressDetails addressDetails, string orderId, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? startTime = default(System.DateTime?), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            OrderItemDetails = orderItemDetails;
            AddressDetails = addressDetails;
            StartTime = startTime;
            OrderId = orderId;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets represents order item details.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orderItemDetails")]
        public OrderItemDetails OrderItemDetails { get; set; }

        /// <summary>
        /// Gets or sets represents shipping and return address for order item
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressDetails")]
        public AddressDetails AddressDetails { get; set; }

        /// <summary>
        /// Gets start time of order item
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets or sets id of the order to which order item belongs to
        /// </summary>
        [JsonProperty(PropertyName = "properties.orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets represents resource creation and update time
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (OrderItemDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrderItemDetails");
            }
            if (AddressDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressDetails");
            }
            if (OrderId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrderId");
            }
            if (OrderItemDetails != null)
            {
                OrderItemDetails.Validate();
            }
            if (AddressDetails != null)
            {
                AddressDetails.Validate();
            }
        }
    }
}
