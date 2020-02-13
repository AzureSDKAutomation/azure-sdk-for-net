// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema Contract details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SchemaContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SchemaContract class.
        /// </summary>
        public SchemaContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchemaContract class.
        /// </summary>
        /// <param name="contentType">Must be a valid a media type used in a
        /// Content-Type header as defined in the RFC 2616. Media type of the
        /// schema document (e.g. application/json, application/xml).
        /// &lt;/br&gt; - `Swagger` Schema use
        /// `application/vnd.ms-azure-apim.swagger.definitions+json`
        /// &lt;/br&gt; - `WSDL` Schema use
        /// `application/vnd.ms-azure-apim.xsd+xml` &lt;/br&gt; - `OpenApi`
        /// Schema use `application/vnd.oai.openapi.components+json`
        /// &lt;/br&gt; - `WADL Schema` use
        /// `application/vnd.ms-azure-apim.wadl.grammars+xml`.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="value">Json escaped string defining the document
        /// representing the Schema. Used for schemas other than
        /// Swagger/OpenAPI.</param>
        /// <param name="definitions">Types definitions. Used for
        /// Swagger/OpenAPI schemas only, null otherwise.</param>
        public SchemaContract(string contentType, string id = default(string), string name = default(string), string type = default(string), string value = default(string), object definitions = default(object))
            : base(id, name, type)
        {
            ContentType = contentType;
            Value = value;
            Definitions = definitions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets must be a valid a media type used in a Content-Type
        /// header as defined in the RFC 2616. Media type of the schema
        /// document (e.g. application/json, application/xml).
        /// &amp;lt;/br&amp;gt; - `Swagger` Schema use
        /// `application/vnd.ms-azure-apim.swagger.definitions+json`
        /// &amp;lt;/br&amp;gt; - `WSDL` Schema use
        /// `application/vnd.ms-azure-apim.xsd+xml` &amp;lt;/br&amp;gt; -
        /// `OpenApi` Schema use `application/vnd.oai.openapi.components+json`
        /// &amp;lt;/br&amp;gt; - `WADL Schema` use
        /// `application/vnd.ms-azure-apim.wadl.grammars+xml`.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets json escaped string defining the document representing
        /// the Schema. Used for schemas other than Swagger/OpenAPI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.document.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets types definitions. Used for Swagger/OpenAPI schemas
        /// only, null otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "properties.document.definitions")]
        public object Definitions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentType");
            }
        }
    }
}
