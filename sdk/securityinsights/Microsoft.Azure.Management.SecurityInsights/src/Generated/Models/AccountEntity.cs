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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an account entity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Account")]
    [Rest.Serialization.JsonTransformation]
    public partial class AccountEntity : Entity
    {
        /// <summary>
        /// Initializes a new instance of the AccountEntity class.
        /// </summary>
        public AccountEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountEntity class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="additionalData">A bag of custom fields that should be
        /// part of the entity and will be presented to the user.</param>
        /// <param name="friendlyName">The graph item display name which is a
        /// short humanly readable description of the graph item instance. This
        /// property is optional and might be system generated.</param>
        /// <param name="aadTenantId">The Azure Active Directory tenant
        /// id.</param>
        /// <param name="aadUserId">The Azure Active Directory user id.</param>
        /// <param name="accountName">The name of the account. This field
        /// should hold only the name without any domain added to it, i.e.
        /// administrator.</param>
        /// <param name="displayName">The display name of the account.</param>
        /// <param name="hostEntityId">The Host entity id that contains the
        /// account in case it is a local account (not domain joined)</param>
        /// <param name="isDomainJoined">Determines whether this is a domain
        /// account.</param>
        /// <param name="ntDomain">The NetBIOS domain name as it appears in the
        /// alert format – domain\username. Examples: NT AUTHORITY.</param>
        /// <param name="objectGuid">The objectGUID attribute is a single-value
        /// attribute that is the unique identifier for the object, assigned by
        /// active directory.</param>
        /// <param name="puid">The Azure Active Directory Passport User
        /// ID.</param>
        /// <param name="sid">The account security identifier, e.g.
        /// S-1-5-18.</param>
        /// <param name="upnSuffix">The user principal name suffix for the
        /// account, in some cases it is also the domain name. Examples:
        /// contoso.com.</param>
        /// <param name="dnsDomain">The fully qualified domain DNS
        /// name.</param>
        public AccountEntity(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, object> additionalData = default(IDictionary<string, object>), string friendlyName = default(string), string aadTenantId = default(string), string aadUserId = default(string), string accountName = default(string), string displayName = default(string), string hostEntityId = default(string), bool? isDomainJoined = default(bool?), string ntDomain = default(string), System.Guid? objectGuid = default(System.Guid?), string puid = default(string), string sid = default(string), string upnSuffix = default(string), string dnsDomain = default(string))
            : base(id, name, type)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AadTenantId = aadTenantId;
            AadUserId = aadUserId;
            AccountName = accountName;
            DisplayName = displayName;
            HostEntityId = hostEntityId;
            IsDomainJoined = isDomainJoined;
            NtDomain = ntDomain;
            ObjectGuid = objectGuid;
            Puid = puid;
            Sid = sid;
            UpnSuffix = upnSuffix;
            DnsDomain = dnsDomain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a bag of custom fields that should be part of the entity and
        /// will be presented to the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalData")]
        public IDictionary<string, object> AdditionalData { get; private set; }

        /// <summary>
        /// Gets the graph item display name which is a short humanly readable
        /// description of the graph item instance. This property is optional
        /// and might be system generated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; private set; }

        /// <summary>
        /// Gets the Azure Active Directory tenant id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aadTenantId")]
        public string AadTenantId { get; private set; }

        /// <summary>
        /// Gets the Azure Active Directory user id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aadUserId")]
        public string AadUserId { get; private set; }

        /// <summary>
        /// Gets the name of the account. This field should hold only the name
        /// without any domain added to it, i.e. administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets the display name of the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the Host entity id that contains the account in case it is a
        /// local account (not domain joined)
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostEntityId")]
        public string HostEntityId { get; private set; }

        /// <summary>
        /// Gets determines whether this is a domain account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDomainJoined")]
        public bool? IsDomainJoined { get; private set; }

        /// <summary>
        /// Gets the NetBIOS domain name as it appears in the alert format –
        /// domain\username. Examples: NT AUTHORITY.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ntDomain")]
        public string NtDomain { get; private set; }

        /// <summary>
        /// Gets the objectGUID attribute is a single-value attribute that is
        /// the unique identifier for the object, assigned by active directory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.objectGuid")]
        public System.Guid? ObjectGuid { get; private set; }

        /// <summary>
        /// Gets the Azure Active Directory Passport User ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.puid")]
        public string Puid { get; private set; }

        /// <summary>
        /// Gets the account security identifier, e.g. S-1-5-18.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sid")]
        public string Sid { get; private set; }

        /// <summary>
        /// Gets the user principal name suffix for the account, in some cases
        /// it is also the domain name. Examples: contoso.com.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upnSuffix")]
        public string UpnSuffix { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain DNS name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsDomain")]
        public string DnsDomain { get; private set; }

    }
}
