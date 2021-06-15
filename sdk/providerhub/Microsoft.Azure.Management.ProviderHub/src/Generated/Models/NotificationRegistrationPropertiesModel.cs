// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NotificationRegistrationPropertiesModel : NotificationRegistrationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NotificationRegistrationPropertiesModel class.
        /// </summary>
        public NotificationRegistrationPropertiesModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NotificationRegistrationPropertiesModel class.
        /// </summary>
        /// <param name="notificationMode">Possible values include:
        /// 'NotSpecified', 'EventHub', 'WebHook'</param>
        /// <param name="messageScope">Possible values include: 'NotSpecified',
        /// 'RegisteredSubscriptions'</param>
        /// <param name="provisioningState">Possible values include:
        /// 'NotSpecified', 'Accepted', 'Running', 'Creating', 'Created',
        /// 'Deleting', 'Deleted', 'Canceled', 'Failed', 'Succeeded',
        /// 'MovingResources', 'TransientFailure', 'RolloutInProgress'</param>
        public NotificationRegistrationPropertiesModel(string notificationMode = default(string), string messageScope = default(string), IList<string> includedEvents = default(IList<string>), IList<NotificationEndpoint> notificationEndpoints = default(IList<NotificationEndpoint>), string provisioningState = default(string))
            : base(notificationMode, messageScope, includedEvents, notificationEndpoints, provisioningState)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
