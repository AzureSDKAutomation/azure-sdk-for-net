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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// log specifications for operation api
    /// </summary>
    public partial class OperationMetaLogSpecification
    {
        /// <summary>
        /// Initializes a new instance of the OperationMetaLogSpecification
        /// class.
        /// </summary>
        public OperationMetaLogSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationMetaLogSpecification
        /// class.
        /// </summary>
        /// <param name="blobDuration">blob duration of the log</param>
        /// <param name="displayName">localized name of the log
        /// category</param>
        /// <param name="name">name of the log category</param>
        public OperationMetaLogSpecification(string blobDuration = default(string), string displayName = default(string), string name = default(string))
        {
            BlobDuration = blobDuration;
            DisplayName = displayName;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets blob duration of the log
        /// </summary>
        [JsonProperty(PropertyName = "blobDuration")]
        public string BlobDuration { get; set; }

        /// <summary>
        /// Gets or sets localized name of the log category
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets name of the log category
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
