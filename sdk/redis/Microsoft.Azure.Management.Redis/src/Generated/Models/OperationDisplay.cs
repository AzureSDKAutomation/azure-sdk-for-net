// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the localized display information for this particular
    /// operation / action.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">The localized friendly form of the resource
        /// provider name, e.g. Microsoft Monitoring Insights" or "Microsoft
        /// Compute"</param>
        /// <param name="resource">The localized friendly form of the resource
        /// type related to this action/operation � it should match the public
        /// documentation for the resource provider, e.g. "Virtual Machines" or
        /// "Job Schedule Collections"</param>
        /// <param name="operation">Required.The localized friendly name for
        /// the operation, as it should be shown to the user. It should be
        /// concise (to fit in drop downs) but clear (i.e. self-documenting),
        /// e.g. "Create or Update Virtual Machine", "Restart Virtual
        /// Machine"</param>
        /// <param name="description">Required.The localized friendly
        /// description for the operation, as it should be shown to the user.
        /// It should be thorough, yet concise � it will be used in tool tips
        /// and detailed views.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the localized friendly form of the resource provider name,
        /// e.g. Microsoft Monitoring Insights" or "Microsoft Compute"
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; private set; }

        /// <summary>
        /// Gets the localized friendly form of the resource type related to
        /// this action/operation � it should match the public documentation
        /// for the resource provider, e.g. "Virtual Machines" or "Job Schedule
        /// Collections"
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; private set; }

        /// <summary>
        /// Gets required.The localized friendly name for the operation, as it
        /// should be shown to the user. It should be concise (to fit in drop
        /// downs) but clear (i.e. self-documenting), e.g. "Create or Update
        /// Virtual Machine", "Restart Virtual Machine"
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; private set; }

        /// <summary>
        /// Gets required.The localized friendly description for the operation,
        /// as it should be shown to the user. It should be thorough, yet
        /// concise � it will be used in tool tips and detailed views.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

    }
}
