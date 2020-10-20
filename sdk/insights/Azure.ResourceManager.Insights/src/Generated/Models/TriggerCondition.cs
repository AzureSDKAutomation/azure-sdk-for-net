// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The condition that results in the Log Search rule. </summary>
    public partial class TriggerCondition
    {
        /// <summary> Initializes a new instance of TriggerCondition. </summary>
        /// <param name="thresholdOperator"> Evaluation operation for rule - &apos;GreaterThan&apos; or &apos;LessThan. </param>
        /// <param name="threshold"> Result or count threshold based on which rule should be triggered. </param>
        public TriggerCondition(ConditionalOperator thresholdOperator, double threshold)
        {
            ThresholdOperator = thresholdOperator;
            Threshold = threshold;
        }

        /// <summary> Initializes a new instance of TriggerCondition. </summary>
        /// <param name="thresholdOperator"> Evaluation operation for rule - &apos;GreaterThan&apos; or &apos;LessThan. </param>
        /// <param name="threshold"> Result or count threshold based on which rule should be triggered. </param>
        /// <param name="metricTrigger"> Trigger condition for metric query rule. </param>
        internal TriggerCondition(ConditionalOperator thresholdOperator, double threshold, LogMetricTrigger metricTrigger)
        {
            ThresholdOperator = thresholdOperator;
            Threshold = threshold;
            MetricTrigger = metricTrigger;
        }

        /// <summary> Evaluation operation for rule - &apos;GreaterThan&apos; or &apos;LessThan. </summary>
        public ConditionalOperator ThresholdOperator { get; set; }
        /// <summary> Result or count threshold based on which rule should be triggered. </summary>
        public double Threshold { get; set; }
        /// <summary> Trigger condition for metric query rule. </summary>
        public LogMetricTrigger MetricTrigger { get; set; }
    }
}
