// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A notification.
    /// </summary>
    public partial class NotificationChannelFragment : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the NotificationChannelFragment
        /// class.
        /// </summary>
        public NotificationChannelFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationChannelFragment
        /// class.
        /// </summary>
        /// <param name="tags">The tags of the resource.</param>
        public NotificationChannelFragment(IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(tags)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
