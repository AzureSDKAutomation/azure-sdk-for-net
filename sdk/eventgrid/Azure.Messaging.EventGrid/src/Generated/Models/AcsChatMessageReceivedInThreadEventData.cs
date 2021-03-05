// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Communication.ChatMessageReceivedInThread event. </summary>
    public partial class AcsChatMessageReceivedInThreadEventData : AcsChatMessageEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of AcsChatMessageReceivedInThreadEventData. </summary>
        internal AcsChatMessageReceivedInThreadEventData()
        {
        }

        /// <summary> Initializes a new instance of AcsChatMessageReceivedInThreadEventData. </summary>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="messageId"> The chat message id. </param>
        /// <param name="senderCommunicationIdentifier"> The communication identifier of the sender. </param>
        /// <param name="senderDisplayName"> The display name of the sender. </param>
        /// <param name="composeTime"> The original compose time of the message. </param>
        /// <param name="type"> The type of the message. </param>
        /// <param name="version"> The version of the message. </param>
        /// <param name="messageBody"> The body of the chat message. </param>
        internal AcsChatMessageReceivedInThreadEventData(string threadId, string messageId, CommunicationIdentifierModel senderCommunicationIdentifier, string senderDisplayName, DateTimeOffset? composeTime, string type, long? version, string messageBody) : base(threadId, messageId, senderCommunicationIdentifier, senderDisplayName, composeTime, type, version)
        {
            MessageBody = messageBody;
        }

        /// <summary> The body of the chat message. </summary>
        public string MessageBody { get; }
    }
}