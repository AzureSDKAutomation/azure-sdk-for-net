// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Synapse Workspace Sql Pool Table data set.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SynapseWorkspaceSqlPoolTable")]
    [Rest.Serialization.JsonTransformation]
    public partial class SynapseWorkspaceSqlPoolTableDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SynapseWorkspaceSqlPoolTableDataSet class.
        /// </summary>
        public SynapseWorkspaceSqlPoolTableDataSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SynapseWorkspaceSqlPoolTableDataSet class.
        /// </summary>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId">Resource id of
        /// the Synapse Workspace SQL Pool Table</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetId">Unique id for identifying a data set
        /// resource</param>
        public SynapseWorkspaceSqlPoolTableDataSet(string synapseWorkspaceSqlPoolTableResourceId, string id = default(string), string name = default(string), SystemData systemData = default(SystemData), string type = default(string), string dataSetId = default(string))
            : base(id, name, systemData, type)
        {
            DataSetId = dataSetId;
            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique id for identifying a data set resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; private set; }

        /// <summary>
        /// Gets or sets resource id of the Synapse Workspace SQL Pool Table
        /// </summary>
        [JsonProperty(PropertyName = "properties.synapseWorkspaceSqlPoolTableResourceId")]
        public string SynapseWorkspaceSqlPoolTableResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SynapseWorkspaceSqlPoolTableResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SynapseWorkspaceSqlPoolTableResourceId");
            }
        }
    }
}
