// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Modern reservation recommendation.
    /// </summary>
    [Newtonsoft.Json.JsonObject("modern")]
    [Rest.Serialization.JsonTransformation]
    public partial class ModernReservationRecommendation : ReservationRecommendation
    {
        /// <summary>
        /// Initializes a new instance of the ModernReservationRecommendation
        /// class.
        /// </summary>
        public ModernReservationRecommendation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModernReservationRecommendation
        /// class.
        /// </summary>
        /// <param name="id">The full qualified ARM ID of an event.</param>
        /// <param name="name">The ID that uniquely identifies an event.
        /// </param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">The etag for the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">Resource location</param>
        /// <param name="sku">Resource sku</param>
        /// <param name="modernReservationRecommendationLocation">Resource
        /// Location.</param>
        /// <param name="lookBackPeriod">The number of days of usage to look
        /// back for recommendation.</param>
        /// <param name="instanceFlexibilityRatio">The instance Flexibility
        /// Ratio.</param>
        /// <param name="instanceFlexibilityGroup">The instance Flexibility
        /// Group.</param>
        /// <param name="normalizedSize">The normalized Size.</param>
        /// <param name="recommendedQuantityNormalized">The recommended
        /// Quantity Normalized.</param>
        /// <param name="meterId">The meter id (GUID)</param>
        /// <param name="term">RI recommendations in one or three year
        /// terms.</param>
        /// <param name="costWithNoReservedInstances">The total amount of cost
        /// without reserved instances.</param>
        /// <param name="recommendedQuantity">Recommended quality for reserved
        /// instances.</param>
        /// <param name="totalCostWithReservedInstances">The total amount of
        /// cost with reserved instances.</param>
        /// <param name="netSavings">Total estimated savings with reserved
        /// instances.</param>
        /// <param name="firstUsageDate">The usage date for looking
        /// back.</param>
        /// <param name="scope">Shared or single recommendation.</param>
        /// <param name="skuProperties">List of sku properties</param>
        /// <param name="skuName">This is the ARM Sku name.</param>
        public ModernReservationRecommendation(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string sku = default(string), string modernReservationRecommendationLocation = default(string), int? lookBackPeriod = default(int?), double? instanceFlexibilityRatio = default(double?), string instanceFlexibilityGroup = default(string), string normalizedSize = default(string), double? recommendedQuantityNormalized = default(double?), System.Guid? meterId = default(System.Guid?), string term = default(string), Amount costWithNoReservedInstances = default(Amount), decimal? recommendedQuantity = default(decimal?), Amount totalCostWithReservedInstances = default(Amount), Amount netSavings = default(Amount), System.DateTime? firstUsageDate = default(System.DateTime?), string scope = default(string), IList<SkuProperty> skuProperties = default(IList<SkuProperty>), string skuName = default(string))
            : base(id, name, type, etag, tags, location, sku)
        {
            ModernReservationRecommendationLocation = modernReservationRecommendationLocation;
            LookBackPeriod = lookBackPeriod;
            InstanceFlexibilityRatio = instanceFlexibilityRatio;
            InstanceFlexibilityGroup = instanceFlexibilityGroup;
            NormalizedSize = normalizedSize;
            RecommendedQuantityNormalized = recommendedQuantityNormalized;
            MeterId = meterId;
            Term = term;
            CostWithNoReservedInstances = costWithNoReservedInstances;
            RecommendedQuantity = recommendedQuantity;
            TotalCostWithReservedInstances = totalCostWithReservedInstances;
            NetSavings = netSavings;
            FirstUsageDate = firstUsageDate;
            Scope = scope;
            SkuProperties = skuProperties;
            SkuName = skuName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string ModernReservationRecommendationLocation { get; private set; }

        /// <summary>
        /// Gets the number of days of usage to look back for recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lookBackPeriod")]
        public int? LookBackPeriod { get; private set; }

        /// <summary>
        /// Gets the instance Flexibility Ratio.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceFlexibilityRatio")]
        public double? InstanceFlexibilityRatio { get; private set; }

        /// <summary>
        /// Gets the instance Flexibility Group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceFlexibilityGroup")]
        public string InstanceFlexibilityGroup { get; private set; }

        /// <summary>
        /// Gets the normalized Size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.normalizedSize")]
        public string NormalizedSize { get; private set; }

        /// <summary>
        /// Gets the recommended Quantity Normalized.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendedQuantityNormalized")]
        public double? RecommendedQuantityNormalized { get; private set; }

        /// <summary>
        /// Gets the meter id (GUID)
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public System.Guid? MeterId { get; private set; }

        /// <summary>
        /// Gets RI recommendations in one or three year terms.
        /// </summary>
        [JsonProperty(PropertyName = "properties.term")]
        public string Term { get; private set; }

        /// <summary>
        /// Gets the total amount of cost without reserved instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costWithNoReservedInstances")]
        public Amount CostWithNoReservedInstances { get; private set; }

        /// <summary>
        /// Gets recommended quality for reserved instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendedQuantity")]
        public decimal? RecommendedQuantity { get; private set; }

        /// <summary>
        /// Gets the total amount of cost with reserved instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalCostWithReservedInstances")]
        public Amount TotalCostWithReservedInstances { get; private set; }

        /// <summary>
        /// Gets total estimated savings with reserved instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.netSavings")]
        public Amount NetSavings { get; private set; }

        /// <summary>
        /// Gets the usage date for looking back.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firstUsageDate")]
        public System.DateTime? FirstUsageDate { get; private set; }

        /// <summary>
        /// Gets shared or single recommendation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; private set; }

        /// <summary>
        /// Gets list of sku properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuProperties")]
        public IList<SkuProperty> SkuProperties { get; private set; }

        /// <summary>
        /// Gets this is the ARM Sku name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuName")]
        public string SkuName { get; private set; }

    }
}
