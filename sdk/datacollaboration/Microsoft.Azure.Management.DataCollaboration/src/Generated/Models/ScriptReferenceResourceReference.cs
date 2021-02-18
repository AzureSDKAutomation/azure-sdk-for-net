// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ResourceReference used to only allow access if the resource is used
    /// within the specified Azure scriptReference.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ScriptReference")]
    [Rest.Serialization.JsonTransformation]
    public partial class ScriptReferenceResourceReference : ResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the ScriptReferenceResourceReference
        /// class.
        /// </summary>
        public ScriptReferenceResourceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptReferenceResourceReference
        /// class.
        /// </summary>
        /// <param name="participantDetails">Participant Details of the
        /// resource</param>
        /// <param name="resourceId">Id of the azure resource</param>
        /// <param name="resourceName">Name of the azure resource</param>
        /// <param name="resourceType">Type of the azure resource</param>
        /// <param name="systemData">SystemData Info of resource</param>
        /// <param name="purpose">Script purpose. Possible values include:
        /// 'Body', 'InputAdapter', 'OutputAdapter'</param>
        /// <param name="revision">The revision number of the scriptReference
        /// being referenced.
        /// If omitted, the scriptReference latest version will be
        /// referenced.</param>
        /// <param name="scriptId">The unique identifier of the referenced
        /// script</param>
        /// <param name="scriptKind">Kind of the referenced script. Possible
        /// values include: 'SynapseSpark'</param>
        /// <param name="scriptReferenceId">The unique identifier of the
        /// scriptReference</param>
        /// <param name="sinks">The list of parameters the scriptReference can
        /// use as it's data sinks</param>
        /// <param name="sources">The list of parameters the scriptReference
        /// can use as it's data sources</param>
        public ScriptReferenceResourceReference(ResourceReferenceParticipantDetails participantDetails = default(ResourceReferenceParticipantDetails), string resourceId = default(string), string resourceName = default(string), string resourceType = default(string), ResourceReferenceSystemData systemData = default(ResourceReferenceSystemData), string purpose = default(string), int? revision = default(int?), string scriptId = default(string), string scriptKind = default(string), string scriptReferenceId = default(string), IList<string> sinks = default(IList<string>), IList<string> sources = default(IList<string>))
            : base(participantDetails, resourceId, resourceName, resourceType, systemData)
        {
            Purpose = purpose;
            Revision = revision;
            ScriptId = scriptId;
            ScriptKind = scriptKind;
            ScriptReferenceId = scriptReferenceId;
            Sinks = sinks;
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets script purpose. Possible values include: 'Body',
        /// 'InputAdapter', 'OutputAdapter'
        /// </summary>
        [JsonProperty(PropertyName = "properties.purpose")]
        public string Purpose { get; private set; }

        /// <summary>
        /// Gets the revision number of the scriptReference being referenced.
        /// If omitted, the scriptReference latest version will be referenced.
        /// </summary>
        [JsonProperty(PropertyName = "properties.revision")]
        public int? Revision { get; private set; }

        /// <summary>
        /// Gets the unique identifier of the referenced script
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptId")]
        public string ScriptId { get; private set; }

        /// <summary>
        /// Gets kind of the referenced script. Possible values include:
        /// 'SynapseSpark'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptKind")]
        public string ScriptKind { get; private set; }

        /// <summary>
        /// Gets the unique identifier of the scriptReference
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptReferenceId")]
        public string ScriptReferenceId { get; private set; }

        /// <summary>
        /// Gets the list of parameters the scriptReference can use as it's
        /// data sinks
        /// </summary>
        [JsonProperty(PropertyName = "properties.sinks")]
        public IList<string> Sinks { get; private set; }

        /// <summary>
        /// Gets the list of parameters the scriptReference can use as it's
        /// data sources
        /// </summary>
        [JsonProperty(PropertyName = "properties.sources")]
        public IList<string> Sources { get; private set; }

    }
}
