// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the script sources for run command.
    /// </summary>
    public partial class VirtualMachineRunCommandScriptSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineRunCommandScriptSource class.
        /// </summary>
        public VirtualMachineRunCommandScriptSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineRunCommandScriptSource class.
        /// </summary>
        /// <param name="script">Specifies the script content to be executed on
        /// the VM.</param>
        /// <param name="scriptUri">Specifies the script download
        /// location.</param>
        public VirtualMachineRunCommandScriptSource(string script = default(string), string scriptUri = default(string))
        {
            Script = script;
            ScriptUri = scriptUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the script content to be executed on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

        /// <summary>
        /// Gets or sets specifies the script download location.
        /// </summary>
        [JsonProperty(PropertyName = "scriptUri")]
        public string ScriptUri { get; set; }

    }
}
