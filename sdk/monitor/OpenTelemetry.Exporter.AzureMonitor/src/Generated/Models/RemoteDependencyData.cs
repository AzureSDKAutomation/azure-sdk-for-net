// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> An instance of Remote Dependency represents an interaction of the monitored component with a remote component/service like SQL or an HTTP endpoint. </summary>
    public partial class RemoteDependencyData : MonitorDomain
    {
        /// <summary> Initializes a new instance of RemoteDependencyData. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="name"> Name of the command initiated with this dependency call. Low cardinality value. Examples are stored procedure name and URL path template. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="duration"/> is null. </exception>
        public RemoteDependencyData(int version, string name, string duration) : base(version)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (duration == null)
            {
                throw new ArgumentNullException(nameof(duration));
            }

            Name = name;
            Duration = duration;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Identifier of a dependency call instance. Used for correlation with the request telemetry item corresponding to this dependency call. </summary>
        public string Id { get; set; }
        /// <summary> Name of the command initiated with this dependency call. Low cardinality value. Examples are stored procedure name and URL path template. </summary>
        public string Name { get; }
        /// <summary> Result code of a dependency call. Examples are SQL error code and HTTP status code. </summary>
        public string ResultCode { get; set; }
        /// <summary> Command initiated by this dependency call. Examples are SQL statement and HTTP URL with all query parameters. </summary>
        public string Data { get; set; }
        /// <summary> Dependency type name. Very low cardinality value for logical grouping of dependencies and interpretation of other fields like commandName and resultCode. Examples are SQL, Azure table, and HTTP. </summary>
        public string Type { get; set; }
        /// <summary> Target site of a dependency call. Examples are server name, host address. </summary>
        public string Target { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </summary>
        public string Duration { get; }
        /// <summary> Indication of successful or unsuccessful call. </summary>
        public bool? Success { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
