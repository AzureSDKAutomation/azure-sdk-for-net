﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Analytics.Synapse.Artifacts;
using Azure.Core.TestFramework;
using NUnit.Framework;
using System;
using System.IO;

namespace Azure.Analytics.Synapse.Tests.Artifacts
{
    [NonParallelizable]
    public abstract class ArtifactsClientTestBase : RecordedTestBase<SynapseTestEnvironment>
    {
        public PipelineClient PipelineClient { get; set; }

        public NotebookClient NotebookClient { get; set; }

        public TriggerClient TriggerClient { get; set; }

        public LinkedServiceClient LinkedServiceClient { get; set; }

        public DatasetClient DatasetClient { get; set; }

        public DataFlowClient DataFlowClient { get; set; }

        protected ArtifactsClientTestBase(bool isAsync) : base(isAsync)
        {
#if DEBUG
            SaveDebugRecordingsOnFailure = true;
#endif
        }

        public override void StartTestRecording()
        {
            base.StartTestRecording();

            PipelineClient = CreatePipelineClient();
            NotebookClient = CreateNotebookClient();
            TriggerClient = CreateTriggerClient();
            LinkedServiceClient = CreateLinkedServiceClient();
            DatasetClient = CreateDatasetClient();
            DataFlowClient = CreateDataFlowClient();
        }

        public override void StopTestRecording()
        {
            Recording.RewriteSessionRecords(GetSessionFilePath());
            Recording.ClearTextReplacementRules();
            base.StopTestRecording();
        }

        private string GetSessionFilePath(string name = null)
        {
            TestContext.TestAdapter testAdapter = TestContext.CurrentContext.Test;

            name ??= testAdapter.Name;

            string className = testAdapter.ClassName.Substring(testAdapter.ClassName.LastIndexOf('.') + 1);
            string fileName = name + (IsAsync ? "Async" : string.Empty) + ".json";
            return Path.Combine(TestContext.CurrentContext.TestDirectory, "SessionRecords", className, fileName);
        }

        internal PipelineClient CreatePipelineClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new PipelineClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                recording.InstrumentClientOptions(new ArtifactsClientOptions())));
        }

        internal NotebookClient CreateNotebookClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new NotebookClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                recording.InstrumentClientOptions(new ArtifactsClientOptions())));
        }

        internal TriggerClient CreateTriggerClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new TriggerClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                recording.InstrumentClientOptions(new ArtifactsClientOptions())));
        }

        internal LinkedServiceClient CreateLinkedServiceClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new LinkedServiceClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                recording.InstrumentClientOptions(new ArtifactsClientOptions())));
        }

        internal DatasetClient CreateDatasetClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new DatasetClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                recording.InstrumentClientOptions(new ArtifactsClientOptions())));
        }

        internal DataFlowClient CreateDataFlowClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new DataFlowClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                recording.InstrumentClientOptions(new ArtifactsClientOptions())));
        }
    }
}
