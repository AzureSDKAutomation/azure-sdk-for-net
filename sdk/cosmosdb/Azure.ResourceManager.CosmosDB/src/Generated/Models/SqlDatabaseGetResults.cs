// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB SQL database. </summary>
    public partial class SqlDatabaseGetResults : ARMResourceProperties
    {
        /// <summary> Initializes a new instance of SqlDatabaseGetResults. </summary>
        public SqlDatabaseGetResults()
        {
        }

        /// <summary> Initializes a new instance of SqlDatabaseGetResults. </summary>
        /// <param name="id"> The unique resource identifier of the ARM resource. </param>
        /// <param name="name"> The name of the ARM resource. </param>
        /// <param name="type"> The type of Azure resource. </param>
        /// <param name="location"> The location of the resource group to which the resource belongs. </param>
        /// <param name="tags"> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with &quot;defaultExperience&quot;: &quot;Cassandra&quot;. Current &quot;defaultExperience&quot; values also include &quot;Table&quot;, &quot;Graph&quot;, &quot;DocumentDB&quot;, and &quot;MongoDB&quot;. </param>
        /// <param name="resource"> . </param>
        /// <param name="options"> Cosmos DB options resource object. </param>
        internal SqlDatabaseGetResults(string id, string name, string type, string location, IDictionary<string, string> tags, SqlDatabaseGetPropertiesResource resource, OptionsResource options) : base(id, name, type, location, tags)
        {
            Resource = resource;
            Options = options;
        }

        public SqlDatabaseGetPropertiesResource Resource { get; set; }
        /// <summary> Cosmos DB options resource object. </summary>
        public OptionsResource Options { get; }
    }
}
