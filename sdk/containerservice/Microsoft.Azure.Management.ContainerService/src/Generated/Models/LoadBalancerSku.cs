// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{

    /// <summary>
    /// Defines values for LoadBalancerSku.
    /// </summary>
    public static class LoadBalancerSku
    {
        /// <summary>
        /// Use a a standard Load Balancer. This is the recommended Load
        /// Balancer SKU. For more information about on working with the load
        /// balancer in the managed cluster, see the [standard Load
        /// Balancer](https://docs.microsoft.com/azure/aks/load-balancer-standard)
        /// article.
        /// </summary>
        public const string Standard = "standard";
        /// <summary>
        /// Use a basic Load Balancer with limited functionality.
        /// </summary>
        public const string Basic = "basic";
    }
}
