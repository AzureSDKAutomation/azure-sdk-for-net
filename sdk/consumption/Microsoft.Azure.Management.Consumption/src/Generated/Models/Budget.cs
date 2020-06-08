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
    /// A budget resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Budget : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Budget class.
        /// </summary>
        public Budget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Budget class.
        /// </summary>
        /// <param name="amount">The total amount of cost to track with the
        /// budget</param>
        /// <param name="timeGrain">The time covered by a budget. Tracking of
        /// the amount will be reset based on the time grain. BillingMonth,
        /// BillingQuarter, and BillingAnnual are only supported by WD
        /// customers. Possible values include: 'Monthly', 'Quarterly',
        /// 'Annually', 'BillingMonth', 'BillingQuarter',
        /// 'BillingAnnual'</param>
        /// <param name="timePeriod">Has start and end date of the budget. The
        /// start date must be first of the month and should be less than the
        /// end date. Budget start date must be on or after June 1, 2017.
        /// Future start date should not be more than twelve months. Past start
        /// date should  be selected within the timegrain period. There are no
        /// restrictions on the end date.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="eTag">eTag of the resource. To handle concurrent
        /// update scenario, this field will be used to determine whether the
        /// user is updating the latest version or not.</param>
        /// <param name="filter">May be used to filter budgets by resource
        /// group, resource, or meter.</param>
        /// <param name="currentSpend">The current amount of cost which is
        /// being tracked for a budget.</param>
        /// <param name="notifications">Dictionary of notifications associated
        /// with the budget. Budget can have up to five notifications.</param>
        public Budget(decimal amount, string timeGrain, BudgetTimePeriod timePeriod, string id = default(string), string name = default(string), string type = default(string), string eTag = default(string), BudgetFilter filter = default(BudgetFilter), CurrentSpend currentSpend = default(CurrentSpend), IDictionary<string, Notification> notifications = default(IDictionary<string, Notification>))
            : base(id, name, type, eTag)
        {
            Amount = amount;
            TimeGrain = timeGrain;
            TimePeriod = timePeriod;
            Filter = filter;
            CurrentSpend = currentSpend;
            Notifications = notifications;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for Budget class.
        /// </summary>
        static Budget()
        {
            Category = "Cost";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total amount of cost to track with the budget
        /// </summary>
        [JsonProperty(PropertyName = "properties.amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the time covered by a budget. Tracking of the amount
        /// will be reset based on the time grain. BillingMonth,
        /// BillingQuarter, and BillingAnnual are only supported by WD
        /// customers. Possible values include: 'Monthly', 'Quarterly',
        /// 'Annually', 'BillingMonth', 'BillingQuarter', 'BillingAnnual'
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets has start and end date of the budget. The start date
        /// must be first of the month and should be less than the end date.
        /// Budget start date must be on or after June 1, 2017. Future start
        /// date should not be more than twelve months. Past start date should
        /// be selected within the timegrain period. There are no restrictions
        /// on the end date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timePeriod")]
        public BudgetTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Gets or sets may be used to filter budgets by resource group,
        /// resource, or meter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filter")]
        public BudgetFilter Filter { get; set; }

        /// <summary>
        /// Gets the current amount of cost which is being tracked for a
        /// budget.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentSpend")]
        public CurrentSpend CurrentSpend { get; private set; }

        /// <summary>
        /// Gets or sets dictionary of notifications associated with the
        /// budget. Budget can have up to five notifications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notifications")]
        public IDictionary<string, Notification> Notifications { get; set; }

        /// <summary>
        /// The category of the budget, whether the budget tracks cost or
        /// usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public static string Category { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeGrain == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeGrain");
            }
            if (TimePeriod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimePeriod");
            }
            if (TimePeriod != null)
            {
                TimePeriod.Validate();
            }
            if (Filter != null)
            {
                Filter.Validate();
            }
            if (Notifications != null)
            {
                foreach (var valueElement in Notifications.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
