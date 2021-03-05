// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Iot.DeviceUpdate.Models
{
    /// <summary> Update identifier. </summary>
    public partial class UpdateId
    {
        /// <summary> Initializes a new instance of UpdateId. </summary>
        /// <param name="provider"> Update provider. </param>
        /// <param name="name"> Update name. </param>
        /// <param name="version"> Update version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="provider"/>, <paramref name="name"/>, or <paramref name="version"/> is null. </exception>
        public UpdateId(string provider, string name, string version)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            Provider = provider;
            Name = name;
            Version = version;
        }

        /// <summary> Update provider. </summary>
        public string Provider { get; set; }
        /// <summary> Update name. </summary>
        public string Name { get; set; }
        /// <summary> Update version. </summary>
        public string Version { get; set; }
    }
}