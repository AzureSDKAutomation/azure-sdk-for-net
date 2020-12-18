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
    /// Modern usage detail.
    /// </summary>
    [Newtonsoft.Json.JsonObject("modern")]
    [Rest.Serialization.JsonTransformation]
    public partial class ModernUsageDetail : UsageDetail
    {
        /// <summary>
        /// Initializes a new instance of the ModernUsageDetail class.
        /// </summary>
        public ModernUsageDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModernUsageDetail class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="billingAccountId">Billing Account identifier.</param>
        /// <param name="billingAccountName">Name of the Billing
        /// Account.</param>
        /// <param name="billingPeriodStartDate">Billing Period Start Date as
        /// in the invoice.</param>
        /// <param name="billingPeriodEndDate">Billing Period End Date as in
        /// the invoice.</param>
        /// <param name="billingProfileId">Identifier for the billing profile
        /// that groups costs across invoices in the a singular billing
        /// currency across across the customers who have onboarded the
        /// Microsoft customer agreement and the customers in CSP who have made
        /// entitlement purchases like SaaS, Marketplace, RI, etc.</param>
        /// <param name="billingProfileName">Name of the billing profile that
        /// groups costs across invoices in the a singular billing currency
        /// across across the customers who have onboarded the Microsoft
        /// customer agreement and the customers in CSP who have made
        /// entitlement purchases like SaaS, Marketplace, RI, etc.</param>
        /// <param name="subscriptionGuid">Unique Microsoft generated
        /// identifier for the Azure Subscription.</param>
        /// <param name="subscriptionName">Name of the Azure
        /// Subscription.</param>
        /// <param name="date">Date for the usage record.</param>
        /// <param name="product">Name of the product that has accrued charges
        /// by consumption or purchase as listed in the invoice. Not available
        /// for Marketplace.</param>
        /// <param name="meterId">The meter id (GUID). Not available for
        /// marketplace. For reserved instance this represents the primary
        /// meter for which the reservation was purchased. For the actual VM
        /// Size for which the reservation is purchased see
        /// productOrderName.</param>
        /// <param name="meterName">Identifies the name of the meter against
        /// which consumption is measured.</param>
        /// <param name="meterRegion">Identifies the location of the datacenter
        /// for certain services that are priced based on datacenter
        /// location.</param>
        /// <param name="meterCategory">Identifies the top-level service for
        /// the usage.</param>
        /// <param name="meterSubCategory">Defines the type or sub-category of
        /// Azure service that can affect the rate.</param>
        /// <param name="serviceFamily">List the service family for the product
        /// purchased or charged (Example: Storage ; Compute).</param>
        /// <param name="quantity">Measure the quantity purchased or
        /// consumed.The amount of the meter used during the billing
        /// period.</param>
        /// <param name="unitOfMeasure">Identifies the Unit that the service is
        /// charged in. For example, GB, hours, 10,000 s.</param>
        /// <param name="instanceName">Instance Name.</param>
        /// <param name="costInUSD">Estimated extendedCost or blended cost
        /// before tax in USD.</param>
        /// <param name="unitPrice">Unit Price is the price applicable to you.
        /// (your EA or other contract price).</param>
        /// <param name="billingCurrencyCode">The currency defining the billed
        /// cost.</param>
        /// <param name="resourceLocation">Name of the resource
        /// location.</param>
        /// <param name="consumedService">Consumed service name. Name of the
        /// azure resource provider that emits the usage or was purchased. This
        /// value is not provided for marketplace usage.</param>
        /// <param name="serviceInfo1">Service Info 1.</param>
        /// <param name="serviceInfo2">Service Info 2.</param>
        /// <param name="additionalInfo">Additional details of this usage item.
        /// Use this field to get usage line item specific details such as the
        /// actual VM Size (ServiceType) or the ratio in which the reservation
        /// discount is applied.</param>
        /// <param name="invoiceSectionId">Identifier of the project that is
        /// being charged in the invoice. Not applicable for Microsoft Customer
        /// Agreements onboarded by partners.</param>
        /// <param name="invoiceSectionName">Name of the project that is being
        /// charged in the invoice. Not applicable for Microsoft Customer
        /// Agreements onboarded by partners.</param>
        /// <param name="costCenter">The cost center of this department if it
        /// is a department and a cost center is provided.</param>
        /// <param name="resourceGroup">Name of the Azure resource group used
        /// for cohesive lifecycle management of resources.</param>
        /// <param name="reservationId">ARM resource id of the reservation.
        /// Only applies to records relevant to reservations.</param>
        /// <param name="reservationName">User provided display name of the
        /// reservation. Last known name for a particular day is populated in
        /// the daily data. Only applies to records relevant to
        /// reservations.</param>
        /// <param name="productOrderId">The identifier for the asset or Azure
        /// plan name that the subscription belongs to. For example: Azure
        /// Plan. For reservations this is the Reservation Order ID.</param>
        /// <param name="productOrderName">Product Order Name. For reservations
        /// this is the SKU that was purchased.</param>
        /// <param name="isAzureCreditEligible">Determines if the cost is
        /// eligible to be paid for using Azure credits.</param>
        /// <param name="term">Term (in months). Displays the term for the
        /// validity of the offer. For example. In case of reserved instances
        /// it displays 12 months for yearly term of reserved instance. For one
        /// time purchases or recurring purchases, the terms displays 1 month;
        /// This is not applicable for Azure consumption.</param>
        /// <param name="publisherName">Name of the publisher of the service
        /// including Microsoft or Third Party publishers.</param>
        /// <param name="publisherType">Type of publisher that identifies if
        /// the publisher is first party, third party reseller or third party
        /// agency.</param>
        /// <param name="chargeType">Indicates a charge represents credits,
        /// usage, a Marketplace purchase, a reservation fee, or a
        /// refund.</param>
        /// <param name="frequency">Indicates how frequently this charge will
        /// occur. OneTime for purchases which only happen once, Monthly for
        /// fees which recur every month, and UsageBased for charges based on
        /// how much a service is used.</param>
        /// <param name="costInBillingCurrency">ExtendedCost or blended cost
        /// before tax in billed currency.</param>
        /// <param name="costInPricingCurrency">ExtendedCost or blended cost
        /// before tax in pricing currency to correlate with prices.</param>
        /// <param name="exchangeRate">Exchange rate used in conversion from
        /// pricing currency to billing currency.</param>
        /// <param name="exchangeRateDate">Date on which exchange rate used in
        /// conversion from pricing currency to billing currency.</param>
        /// <param name="invoiceId">Invoice ID as on the invoice where the
        /// specific transaction appears.</param>
        /// <param name="previousInvoiceId">Reference to an original invoice
        /// there is a refund (negative cost). This is populated only when
        /// there is a refund.</param>
        /// <param name="pricingCurrencyCode">Pricing Billing Currency.</param>
        /// <param name="productIdentifier">Identifer for the product that has
        /// accrued charges by consumption or purchase . This is the
        /// concatenated key of productId and SKuId in partner center.</param>
        /// <param name="resourceLocationNormalized">Resource Location
        /// Normalized.</param>
        /// <param name="servicePeriodStartDate">Start date for the rating
        /// period when the service usage was rated for charges. The prices for
        /// Azure services are determined for the rating period.</param>
        /// <param name="servicePeriodEndDate">End date for the period when the
        /// service usage was rated for charges. The prices for Azure services
        /// are determined based on the rating period.</param>
        /// <param name="customerTenantId">Identifier of the customer's AAD
        /// tenant.</param>
        /// <param name="customerName">Name of the customer's AAD
        /// tenant.</param>
        /// <param name="partnerTenantId">Identifier for the partner's AAD
        /// tenant.</param>
        /// <param name="partnerName">Name of the partner' AAD tenant.</param>
        /// <param name="resellerMpnId">MPNId for the reseller associated with
        /// the subscription.</param>
        /// <param name="resellerName">Reseller Name.</param>
        /// <param name="publisherId">Publisher Id.</param>
        /// <param name="marketPrice">Market Price that's charged for the
        /// usage.</param>
        /// <param name="exchangeRatePricingToBilling">Exchange Rate from
        /// pricing currency to billing currency.</param>
        /// <param name="paygCostInBillingCurrency">The amount of PayG cost
        /// before tax in billing currency.</param>
        /// <param name="paygCostInUSD">The amount of PayG cost before tax in
        /// US Dollar currency.</param>
        /// <param name="partnerEarnedCreditRate">Rate of discount applied if
        /// there is a partner earned credit (PEC) based on partner admin link
        /// access.</param>
        /// <param name="partnerEarnedCreditApplied">Flag to indicate if
        /// partner earned credit has been applied or not.</param>
        public ModernUsageDetail(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string billingAccountId = default(string), string billingAccountName = default(string), System.DateTime? billingPeriodStartDate = default(System.DateTime?), System.DateTime? billingPeriodEndDate = default(System.DateTime?), string billingProfileId = default(string), string billingProfileName = default(string), string subscriptionGuid = default(string), string subscriptionName = default(string), System.DateTime? date = default(System.DateTime?), string product = default(string), System.Guid? meterId = default(System.Guid?), string meterName = default(string), string meterRegion = default(string), string meterCategory = default(string), string meterSubCategory = default(string), string serviceFamily = default(string), decimal? quantity = default(decimal?), string unitOfMeasure = default(string), string instanceName = default(string), decimal? costInUSD = default(decimal?), decimal? unitPrice = default(decimal?), string billingCurrencyCode = default(string), string resourceLocation = default(string), string consumedService = default(string), string serviceInfo1 = default(string), string serviceInfo2 = default(string), string additionalInfo = default(string), string invoiceSectionId = default(string), string invoiceSectionName = default(string), string costCenter = default(string), string resourceGroup = default(string), string reservationId = default(string), string reservationName = default(string), string productOrderId = default(string), string productOrderName = default(string), bool? isAzureCreditEligible = default(bool?), string term = default(string), string publisherName = default(string), string publisherType = default(string), string chargeType = default(string), string frequency = default(string), decimal? costInBillingCurrency = default(decimal?), decimal? costInPricingCurrency = default(decimal?), string exchangeRate = default(string), System.DateTime? exchangeRateDate = default(System.DateTime?), string invoiceId = default(string), string previousInvoiceId = default(string), string pricingCurrencyCode = default(string), string productIdentifier = default(string), string resourceLocationNormalized = default(string), System.DateTime? servicePeriodStartDate = default(System.DateTime?), System.DateTime? servicePeriodEndDate = default(System.DateTime?), string customerTenantId = default(string), string customerName = default(string), string partnerTenantId = default(string), string partnerName = default(string), string resellerMpnId = default(string), string resellerName = default(string), string publisherId = default(string), decimal? marketPrice = default(decimal?), decimal? exchangeRatePricingToBilling = default(decimal?), decimal? paygCostInBillingCurrency = default(decimal?), decimal? paygCostInUSD = default(decimal?), decimal? partnerEarnedCreditRate = default(decimal?), string partnerEarnedCreditApplied = default(string))
            : base(id, name, type, tags)
        {
            BillingAccountId = billingAccountId;
            BillingAccountName = billingAccountName;
            BillingPeriodStartDate = billingPeriodStartDate;
            BillingPeriodEndDate = billingPeriodEndDate;
            BillingProfileId = billingProfileId;
            BillingProfileName = billingProfileName;
            SubscriptionGuid = subscriptionGuid;
            SubscriptionName = subscriptionName;
            Date = date;
            Product = product;
            MeterId = meterId;
            MeterName = meterName;
            MeterRegion = meterRegion;
            MeterCategory = meterCategory;
            MeterSubCategory = meterSubCategory;
            ServiceFamily = serviceFamily;
            Quantity = quantity;
            UnitOfMeasure = unitOfMeasure;
            InstanceName = instanceName;
            CostInUSD = costInUSD;
            UnitPrice = unitPrice;
            BillingCurrencyCode = billingCurrencyCode;
            ResourceLocation = resourceLocation;
            ConsumedService = consumedService;
            ServiceInfo1 = serviceInfo1;
            ServiceInfo2 = serviceInfo2;
            AdditionalInfo = additionalInfo;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionName = invoiceSectionName;
            CostCenter = costCenter;
            ResourceGroup = resourceGroup;
            ReservationId = reservationId;
            ReservationName = reservationName;
            ProductOrderId = productOrderId;
            ProductOrderName = productOrderName;
            IsAzureCreditEligible = isAzureCreditEligible;
            Term = term;
            PublisherName = publisherName;
            PublisherType = publisherType;
            ChargeType = chargeType;
            Frequency = frequency;
            CostInBillingCurrency = costInBillingCurrency;
            CostInPricingCurrency = costInPricingCurrency;
            ExchangeRate = exchangeRate;
            ExchangeRateDate = exchangeRateDate;
            InvoiceId = invoiceId;
            PreviousInvoiceId = previousInvoiceId;
            PricingCurrencyCode = pricingCurrencyCode;
            ProductIdentifier = productIdentifier;
            ResourceLocationNormalized = resourceLocationNormalized;
            ServicePeriodStartDate = servicePeriodStartDate;
            ServicePeriodEndDate = servicePeriodEndDate;
            CustomerTenantId = customerTenantId;
            CustomerName = customerName;
            PartnerTenantId = partnerTenantId;
            PartnerName = partnerName;
            ResellerMpnId = resellerMpnId;
            ResellerName = resellerName;
            PublisherId = publisherId;
            MarketPrice = marketPrice;
            ExchangeRatePricingToBilling = exchangeRatePricingToBilling;
            PaygCostInBillingCurrency = paygCostInBillingCurrency;
            PaygCostInUSD = paygCostInUSD;
            PartnerEarnedCreditRate = partnerEarnedCreditRate;
            PartnerEarnedCreditApplied = partnerEarnedCreditApplied;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets billing Account identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountId")]
        public string BillingAccountId { get; private set; }

        /// <summary>
        /// Gets name of the Billing Account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountName")]
        public string BillingAccountName { get; private set; }

        /// <summary>
        /// Gets billing Period Start Date as in the invoice.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodStartDate")]
        public System.DateTime? BillingPeriodStartDate { get; private set; }

        /// <summary>
        /// Gets billing Period End Date as in the invoice.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodEndDate")]
        public System.DateTime? BillingPeriodEndDate { get; private set; }

        /// <summary>
        /// Gets identifier for the billing profile that groups costs across
        /// invoices in the a singular billing currency across across the
        /// customers who have onboarded the Microsoft customer agreement and
        /// the customers in CSP who have made entitlement purchases like SaaS,
        /// Marketplace, RI, etc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets name of the billing profile that groups costs across invoices
        /// in the a singular billing currency across across the customers who
        /// have onboarded the Microsoft customer agreement and the customers
        /// in CSP who have made entitlement purchases like SaaS, Marketplace,
        /// RI, etc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileName")]
        public string BillingProfileName { get; private set; }

        /// <summary>
        /// Gets unique Microsoft generated identifier for the Azure
        /// Subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionGuid")]
        public string SubscriptionGuid { get; private set; }

        /// <summary>
        /// Gets name of the Azure Subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionName")]
        public string SubscriptionName { get; private set; }

        /// <summary>
        /// Gets date for the usage record.
        /// </summary>
        [JsonProperty(PropertyName = "properties.date")]
        public System.DateTime? Date { get; private set; }

        /// <summary>
        /// Gets name of the product that has accrued charges by consumption or
        /// purchase as listed in the invoice. Not available for Marketplace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.product")]
        public string Product { get; private set; }

        /// <summary>
        /// Gets the meter id (GUID). Not available for marketplace. For
        /// reserved instance this represents the primary meter for which the
        /// reservation was purchased. For the actual VM Size for which the
        /// reservation is purchased see productOrderName.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public System.Guid? MeterId { get; private set; }

        /// <summary>
        /// Gets identifies the name of the meter against which consumption is
        /// measured.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterName")]
        public string MeterName { get; private set; }

        /// <summary>
        /// Gets identifies the location of the datacenter for certain services
        /// that are priced based on datacenter location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterRegion")]
        public string MeterRegion { get; private set; }

        /// <summary>
        /// Gets identifies the top-level service for the usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterCategory")]
        public string MeterCategory { get; private set; }

        /// <summary>
        /// Gets defines the type or sub-category of Azure service that can
        /// affect the rate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterSubCategory")]
        public string MeterSubCategory { get; private set; }

        /// <summary>
        /// Gets list the service family for the product purchased or charged
        /// (Example: Storage ; Compute).
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceFamily")]
        public string ServiceFamily { get; private set; }

        /// <summary>
        /// Gets measure the quantity purchased or consumed.The amount of the
        /// meter used during the billing period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// Gets identifies the Unit that the service is charged in. For
        /// example, GB, hours, 10,000 s.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unitOfMeasure")]
        public string UnitOfMeasure { get; private set; }

        /// <summary>
        /// Gets instance Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceName")]
        public string InstanceName { get; private set; }

        /// <summary>
        /// Gets estimated extendedCost or blended cost before tax in USD.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costInUSD")]
        public decimal? CostInUSD { get; private set; }

        /// <summary>
        /// Gets unit Price is the price applicable to you. (your EA or other
        /// contract price).
        /// </summary>
        [JsonProperty(PropertyName = "properties.unitPrice")]
        public decimal? UnitPrice { get; private set; }

        /// <summary>
        /// Gets the currency defining the billed cost.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingCurrencyCode")]
        public string BillingCurrencyCode { get; private set; }

        /// <summary>
        /// Gets name of the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceLocation")]
        public string ResourceLocation { get; private set; }

        /// <summary>
        /// Gets consumed service name. Name of the azure resource provider
        /// that emits the usage or was purchased. This value is not provided
        /// for marketplace usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumedService")]
        public string ConsumedService { get; private set; }

        /// <summary>
        /// Gets service Info 1.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceInfo1")]
        public string ServiceInfo1 { get; private set; }

        /// <summary>
        /// Gets service Info 2.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceInfo2")]
        public string ServiceInfo2 { get; private set; }

        /// <summary>
        /// Gets additional details of this usage item. Use this field to get
        /// usage line item specific details such as the actual VM Size
        /// (ServiceType) or the ratio in which the reservation discount is
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalInfo")]
        public string AdditionalInfo { get; private set; }

        /// <summary>
        /// Gets identifier of the project that is being charged in the
        /// invoice. Not applicable for Microsoft Customer Agreements onboarded
        /// by partners.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets name of the project that is being charged in the invoice. Not
        /// applicable for Microsoft Customer Agreements onboarded by partners.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionName")]
        public string InvoiceSectionName { get; private set; }

        /// <summary>
        /// Gets the cost center of this department if it is a department and a
        /// cost center is provided.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costCenter")]
        public string CostCenter { get; private set; }

        /// <summary>
        /// Gets name of the Azure resource group used for cohesive lifecycle
        /// management of resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; private set; }

        /// <summary>
        /// Gets ARM resource id of the reservation. Only applies to records
        /// relevant to reservations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationId")]
        public string ReservationId { get; private set; }

        /// <summary>
        /// Gets user provided display name of the reservation. Last known name
        /// for a particular day is populated in the daily data. Only applies
        /// to records relevant to reservations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationName")]
        public string ReservationName { get; private set; }

        /// <summary>
        /// Gets the identifier for the asset or Azure plan name that the
        /// subscription belongs to. For example: Azure Plan. For reservations
        /// this is the Reservation Order ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productOrderId")]
        public string ProductOrderId { get; private set; }

        /// <summary>
        /// Gets product Order Name. For reservations this is the SKU that was
        /// purchased.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productOrderName")]
        public string ProductOrderName { get; private set; }

        /// <summary>
        /// Gets determines if the cost is eligible to be paid for using Azure
        /// credits.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAzureCreditEligible")]
        public bool? IsAzureCreditEligible { get; private set; }

        /// <summary>
        /// Gets term (in months). Displays the term for the validity of the
        /// offer. For example. In case of reserved instances it displays 12
        /// months for yearly term of reserved instance. For one time purchases
        /// or recurring purchases, the terms displays 1 month; This is not
        /// applicable for Azure consumption.
        /// </summary>
        [JsonProperty(PropertyName = "properties.term")]
        public string Term { get; private set; }

        /// <summary>
        /// Gets name of the publisher of the service including Microsoft or
        /// Third Party publishers.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherName")]
        public string PublisherName { get; private set; }

        /// <summary>
        /// Gets type of publisher that identifies if the publisher is first
        /// party, third party reseller or third party agency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherType")]
        public string PublisherType { get; private set; }

        /// <summary>
        /// Gets indicates a charge represents credits, usage, a Marketplace
        /// purchase, a reservation fee, or a refund.
        /// </summary>
        [JsonProperty(PropertyName = "properties.chargeType")]
        public string ChargeType { get; private set; }

        /// <summary>
        /// Gets indicates how frequently this charge will occur. OneTime for
        /// purchases which only happen once, Monthly for fees which recur
        /// every month, and UsageBased for charges based on how much a service
        /// is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frequency")]
        public string Frequency { get; private set; }

        /// <summary>
        /// Gets extendedCost or blended cost before tax in billed currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costInBillingCurrency")]
        public decimal? CostInBillingCurrency { get; private set; }

        /// <summary>
        /// Gets extendedCost or blended cost before tax in pricing currency to
        /// correlate with prices.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costInPricingCurrency")]
        public decimal? CostInPricingCurrency { get; private set; }

        /// <summary>
        /// Gets exchange rate used in conversion from pricing currency to
        /// billing currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exchangeRate")]
        public string ExchangeRate { get; private set; }

        /// <summary>
        /// Gets date on which exchange rate used in conversion from pricing
        /// currency to billing currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exchangeRateDate")]
        public System.DateTime? ExchangeRateDate { get; private set; }

        /// <summary>
        /// Gets invoice ID as on the invoice where the specific transaction
        /// appears.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceId")]
        public string InvoiceId { get; private set; }

        /// <summary>
        /// Gets reference to an original invoice there is a refund (negative
        /// cost). This is populated only when there is a refund.
        /// </summary>
        [JsonProperty(PropertyName = "properties.previousInvoiceId")]
        public string PreviousInvoiceId { get; private set; }

        /// <summary>
        /// Gets pricing Billing Currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pricingCurrencyCode")]
        public string PricingCurrencyCode { get; private set; }

        /// <summary>
        /// Gets identifer for the product that has accrued charges by
        /// consumption or purchase . This is the concatenated key of productId
        /// and SKuId in partner center.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productIdentifier")]
        public string ProductIdentifier { get; private set; }

        /// <summary>
        /// Gets resource Location Normalized.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceLocationNormalized")]
        public string ResourceLocationNormalized { get; private set; }

        /// <summary>
        /// Gets start date for the rating period when the service usage was
        /// rated for charges. The prices for Azure services are determined for
        /// the rating period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePeriodStartDate")]
        public System.DateTime? ServicePeriodStartDate { get; private set; }

        /// <summary>
        /// Gets end date for the period when the service usage was rated for
        /// charges. The prices for Azure services are determined based on the
        /// rating period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePeriodEndDate")]
        public System.DateTime? ServicePeriodEndDate { get; private set; }

        /// <summary>
        /// Gets identifier of the customer's AAD tenant.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerTenantId")]
        public string CustomerTenantId { get; private set; }

        /// <summary>
        /// Gets name of the customer's AAD tenant.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerName")]
        public string CustomerName { get; private set; }

        /// <summary>
        /// Gets identifier for the partner's AAD tenant.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerTenantId")]
        public string PartnerTenantId { get; private set; }

        /// <summary>
        /// Gets name of the partner' AAD tenant.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerName")]
        public string PartnerName { get; private set; }

        /// <summary>
        /// Gets mPNId for the reseller associated with the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerMpnId")]
        public string ResellerMpnId { get; private set; }

        /// <summary>
        /// Gets reseller Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerName")]
        public string ResellerName { get; private set; }

        /// <summary>
        /// Gets publisher Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherId")]
        public string PublisherId { get; private set; }

        /// <summary>
        /// Gets market Price that's charged for the usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketPrice")]
        public decimal? MarketPrice { get; private set; }

        /// <summary>
        /// Gets exchange Rate from pricing currency to billing currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exchangeRatePricingToBilling")]
        public decimal? ExchangeRatePricingToBilling { get; private set; }

        /// <summary>
        /// Gets the amount of PayG cost before tax in billing currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.paygCostInBillingCurrency")]
        public decimal? PaygCostInBillingCurrency { get; private set; }

        /// <summary>
        /// Gets the amount of PayG cost before tax in US Dollar currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.paygCostInUSD")]
        public decimal? PaygCostInUSD { get; private set; }

        /// <summary>
        /// Gets rate of discount applied if there is a partner earned credit
        /// (PEC) based on partner admin link access.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerEarnedCreditRate")]
        public decimal? PartnerEarnedCreditRate { get; private set; }

        /// <summary>
        /// Gets flag to indicate if partner earned credit has been applied or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerEarnedCreditApplied")]
        public string PartnerEarnedCreditApplied { get; private set; }

    }
}
