// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Communication.ChatThreadCreated event. </summary>
    public partial class AcsChatThreadCreatedEventData : AcsChatThreadEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of AcsChatThreadCreatedEventData. </summary>
        internal AcsChatThreadCreatedEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
            Participants = new ChangeTrackingList<AcsChatThreadParticipantProperties>();
        }

        /// <summary> Initializes a new instance of AcsChatThreadCreatedEventData. </summary>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="createdByCommunicationIdentifier"> The communication identifier of the user who created the thread. </param>
        /// <param name="properties"> The thread properties. </param>
        /// <param name="participants"> The list of properties of participants who are part of the thread. </param>
        internal AcsChatThreadCreatedEventData(string threadId, DateTimeOffset? createTime, long? version, CommunicationIdentifierModel createdByCommunicationIdentifier, IReadOnlyDictionary<string, object> properties, IReadOnlyList<AcsChatThreadParticipantProperties> participants) : base(threadId, createTime, version)
        {
            CreatedByCommunicationIdentifier = createdByCommunicationIdentifier;
            Properties = properties;
            Participants = participants;
        }

        /// <summary> The communication identifier of the user who created the thread. </summary>
        public CommunicationIdentifierModel CreatedByCommunicationIdentifier { get; }
        /// <summary> The thread properties. </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
        /// <summary> The list of properties of participants who are part of the thread. </summary>
        public IReadOnlyList<AcsChatThreadParticipantProperties> Participants { get; }
    }
}