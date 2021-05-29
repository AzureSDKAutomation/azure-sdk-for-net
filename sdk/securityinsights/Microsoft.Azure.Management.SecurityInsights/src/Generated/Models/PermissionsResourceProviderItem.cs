// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using System.Linq;

    public partial class PermissionsResourceProviderItem : ResourceProvider
    {
        /// <summary>
        /// Initializes a new instance of the PermissionsResourceProviderItem
        /// class.
        /// </summary>
        public PermissionsResourceProviderItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PermissionsResourceProviderItem
        /// class.
        /// </summary>
        /// <param name="provider">Provider name. Possible values include:
        /// 'Microsoft.OperationalInsights/solutions',
        /// 'Microsoft.OperationalInsights/workspaces',
        /// 'Microsoft.OperationalInsights/workspaces/datasources',
        /// 'microsoft.aadiam/diagnosticSettings',
        /// 'Microsoft.OperationalInsights/workspaces/sharedKeys',
        /// 'Microsoft.Authorization/policyAssignments'</param>
        /// <param name="permissionsDisplayText">Permission description
        /// text</param>
        /// <param name="providerDisplayName">Permission provider display
        /// name</param>
        /// <param name="scope">Permission provider scope. Possible values
        /// include: 'ResourceGroup', 'Subscription', 'Workspace'</param>
        /// <param name="requiredPermissions">Required permissions for the
        /// connector</param>
        public PermissionsResourceProviderItem(string provider = default(string), string permissionsDisplayText = default(string), string providerDisplayName = default(string), string scope = default(string), RequiredPermissions requiredPermissions = default(RequiredPermissions))
            : base(provider, permissionsDisplayText, providerDisplayName, scope, requiredPermissions)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
