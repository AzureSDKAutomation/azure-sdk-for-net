// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Database, Server or Elastic Pool Advisor.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Advisor : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Advisor class.
        /// </summary>
        public Advisor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Advisor class.
        /// </summary>
        /// <param name="autoExecuteStatus">Gets the auto-execute status
        /// (whether to let the system execute the recommendations) of this
        /// advisor. Possible values are 'Enabled' and 'Disabled'. Possible
        /// values include: 'Enabled', 'Disabled', 'Default'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="kind">Resource kind.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="advisorStatus">Gets the status of availability of this
        /// advisor to customers. Possible values are 'GA', 'PublicPreview',
        /// 'LimitedPublicPreview' and 'PrivatePreview'. Possible values
        /// include: 'GA', 'PublicPreview', 'LimitedPublicPreview',
        /// 'PrivatePreview'</param>
        /// <param name="autoExecuteStatusInheritedFrom">Gets the resource from
        /// which current value of auto-execute status is inherited.
        /// Auto-execute status can be set on (and inherited from) different
        /// levels in the resource hierarchy. Possible values are
        /// 'Subscription', 'Server', 'ElasticPool', 'Database' and 'Default'
        /// (when status is not explicitly set on any level). Possible values
        /// include: 'Default', 'Subscription', 'Server', 'ElasticPool',
        /// 'Database'</param>
        /// <param name="recommendationsStatus">Gets that status of
        /// recommendations for this advisor and reason for not having any
        /// recommendations. Possible values include, but are not limited to,
        /// 'Ok' (Recommendations available),LowActivity (not enough workload
        /// to analyze), 'DbSeemsTuned' (Database is doing well), etc.</param>
        /// <param name="lastChecked">Gets the time when the current resource
        /// was analyzed for recommendations by this advisor.</param>
        /// <param name="recommendedActions">Gets the recommended actions for
        /// this advisor.</param>
        public Advisor(AutoExecuteStatus autoExecuteStatus, string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string location = default(string), AdvisorStatus? advisorStatus = default(AdvisorStatus?), AutoExecuteStatusInheritedFrom? autoExecuteStatusInheritedFrom = default(AutoExecuteStatusInheritedFrom?), string recommendationsStatus = default(string), System.DateTime? lastChecked = default(System.DateTime?), IList<RecommendedAction> recommendedActions = default(IList<RecommendedAction>))
            : base(id, name, type)
        {
            Kind = kind;
            Location = location;
            AdvisorStatus = advisorStatus;
            AutoExecuteStatus = autoExecuteStatus;
            AutoExecuteStatusInheritedFrom = autoExecuteStatusInheritedFrom;
            RecommendationsStatus = recommendationsStatus;
            LastChecked = lastChecked;
            RecommendedActions = recommendedActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource kind.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets the status of availability of this advisor to customers.
        /// Possible values are 'GA', 'PublicPreview', 'LimitedPublicPreview'
        /// and 'PrivatePreview'. Possible values include: 'GA',
        /// 'PublicPreview', 'LimitedPublicPreview', 'PrivatePreview'
        /// </summary>
        [JsonProperty(PropertyName = "properties.advisorStatus")]
        public AdvisorStatus? AdvisorStatus { get; private set; }

        /// <summary>
        /// Gets the auto-execute status (whether to let the system execute the
        /// recommendations) of this advisor. Possible values are 'Enabled' and
        /// 'Disabled'. Possible values include: 'Enabled', 'Disabled',
        /// 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoExecuteStatus")]
        public AutoExecuteStatus AutoExecuteStatus { get; set; }

        /// <summary>
        /// Gets the resource from which current value of auto-execute status
        /// is inherited. Auto-execute status can be set on (and inherited
        /// from) different levels in the resource hierarchy. Possible values
        /// are 'Subscription', 'Server', 'ElasticPool', 'Database' and
        /// 'Default' (when status is not explicitly set on any level).
        /// Possible values include: 'Default', 'Subscription', 'Server',
        /// 'ElasticPool', 'Database'
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoExecuteStatusInheritedFrom")]
        public AutoExecuteStatusInheritedFrom? AutoExecuteStatusInheritedFrom { get; private set; }

        /// <summary>
        /// Gets that status of recommendations for this advisor and reason for
        /// not having any recommendations. Possible values include, but are
        /// not limited to, 'Ok' (Recommendations available),LowActivity (not
        /// enough workload to analyze), 'DbSeemsTuned' (Database is doing
        /// well), etc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendationsStatus")]
        public string RecommendationsStatus { get; private set; }

        /// <summary>
        /// Gets the time when the current resource was analyzed for
        /// recommendations by this advisor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastChecked")]
        public System.DateTime? LastChecked { get; private set; }

        /// <summary>
        /// Gets the recommended actions for this advisor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendedActions")]
        public IList<RecommendedAction> RecommendedActions { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecommendedActions != null)
            {
                foreach (var element in RecommendedActions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
