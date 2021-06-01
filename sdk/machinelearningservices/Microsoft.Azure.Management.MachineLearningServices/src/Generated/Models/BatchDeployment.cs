// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Batch inference settings per deployment.
    /// </summary>
    public partial class BatchDeployment
    {
        /// <summary>
        /// Initializes a new instance of the BatchDeployment class.
        /// </summary>
        public BatchDeployment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchDeployment class.
        /// </summary>
        /// <param name="codeConfiguration">Code configuration for the endpoint
        /// deployment.</param>
        /// <param name="compute">Configuration for compute binding.</param>
        /// <param name="description">Description of the endpoint
        /// deployment.</param>
        /// <param name="environmentId">ARM resource ID of the environment
        /// specification for the endpoint deployment.</param>
        /// <param name="environmentVariables">Environment variables
        /// configuration for the deployment.</param>
        /// <param name="errorThreshold">Error threshold, if the error count
        /// for the entire input goes above this value,
        /// the batch inference will be aborted. Range is [-1, int.MaxValue].
        /// For FileDataset, this value is the count of file failures.
        /// For TabularDataset, this value is the count of record failures.
        /// If set to -1 (the lower bound), all failures during batch inference
        /// will be ignored.</param>
        /// <param name="loggingLevel">Logging level for batch inference
        /// operation. Possible values include: 'Info', 'Warning',
        /// 'Debug'</param>
        /// <param name="miniBatchSize">Size of the mini-batch passed to each
        /// batch invocation.
        /// For FileDataset, this is the number of files per mini-batch.
        /// For TabularDataset, this is the size of the records in bytes, per
        /// mini-batch.</param>
        /// <param name="model">Reference to the model asset for the endpoint
        /// deployment.</param>
        /// <param name="outputConfiguration">Output configuration for the
        /// batch inference operation.</param>
        /// <param name="partitionKeys">Partition keys list used for Named
        /// partitioning.</param>
        /// <param name="properties">Property dictionary. Properties can be
        /// added, but not removed or altered.</param>
        /// <param name="retrySettings">Retry Settings for the batch inference
        /// operation.</param>
        public BatchDeployment(CodeConfiguration codeConfiguration = default(CodeConfiguration), ComputeConfiguration compute = default(ComputeConfiguration), string description = default(string), string environmentId = default(string), IDictionary<string, string> environmentVariables = default(IDictionary<string, string>), int? errorThreshold = default(int?), string loggingLevel = default(string), long? miniBatchSize = default(long?), AssetReferenceBase model = default(AssetReferenceBase), BatchOutputConfiguration outputConfiguration = default(BatchOutputConfiguration), IList<string> partitionKeys = default(IList<string>), IDictionary<string, string> properties = default(IDictionary<string, string>), BatchRetrySettings retrySettings = default(BatchRetrySettings))
        {
            CodeConfiguration = codeConfiguration;
            Compute = compute;
            Description = description;
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            ErrorThreshold = errorThreshold;
            LoggingLevel = loggingLevel;
            MiniBatchSize = miniBatchSize;
            Model = model;
            OutputConfiguration = outputConfiguration;
            PartitionKeys = partitionKeys;
            Properties = properties;
            RetrySettings = retrySettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets code configuration for the endpoint deployment.
        /// </summary>
        [JsonProperty(PropertyName = "codeConfiguration")]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// Gets or sets configuration for compute binding.
        /// </summary>
        [JsonProperty(PropertyName = "compute")]
        public ComputeConfiguration Compute { get; set; }

        /// <summary>
        /// Gets or sets description of the endpoint deployment.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ARM resource ID of the environment specification for
        /// the endpoint deployment.
        /// </summary>
        [JsonProperty(PropertyName = "environmentId")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Gets or sets environment variables configuration for the
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "environmentVariables")]
        public IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets error threshold, if the error count for the entire
        /// input goes above this value,
        /// the batch inference will be aborted. Range is [-1, int.MaxValue].
        /// For FileDataset, this value is the count of file failures.
        /// For TabularDataset, this value is the count of record failures.
        /// If set to -1 (the lower bound), all failures during batch inference
        /// will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "errorThreshold")]
        public int? ErrorThreshold { get; set; }

        /// <summary>
        /// Gets or sets logging level for batch inference operation. Possible
        /// values include: 'Info', 'Warning', 'Debug'
        /// </summary>
        [JsonProperty(PropertyName = "loggingLevel")]
        public string LoggingLevel { get; set; }

        /// <summary>
        /// Gets or sets size of the mini-batch passed to each batch
        /// invocation.
        /// For FileDataset, this is the number of files per mini-batch.
        /// For TabularDataset, this is the size of the records in bytes, per
        /// mini-batch.
        /// </summary>
        [JsonProperty(PropertyName = "miniBatchSize")]
        public long? MiniBatchSize { get; set; }

        /// <summary>
        /// Gets or sets reference to the model asset for the endpoint
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public AssetReferenceBase Model { get; set; }

        /// <summary>
        /// Gets or sets output configuration for the batch inference
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "outputConfiguration")]
        public BatchOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Gets or sets partition keys list used for Named partitioning.
        /// </summary>
        [JsonProperty(PropertyName = "partitionKeys")]
        public IList<string> PartitionKeys { get; set; }

        /// <summary>
        /// Gets or sets property dictionary. Properties can be added, but not
        /// removed or altered.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets retry Settings for the batch inference operation.
        /// </summary>
        [JsonProperty(PropertyName = "retrySettings")]
        public BatchRetrySettings RetrySettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CodeConfiguration != null)
            {
                CodeConfiguration.Validate();
            }
        }
    }
}
