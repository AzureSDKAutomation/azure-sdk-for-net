// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> A user that got created with an Azure Communication Services resource. </summary>
    public partial class CommunicationUserIdentifierModel
    {
        /// <summary> Initializes a new instance of CommunicationUserIdentifierModel. </summary>
        /// <param name="id"> The Id of the communication user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal CommunicationUserIdentifierModel(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> The Id of the communication user. </summary>
        public string Id { get; }
    }
}