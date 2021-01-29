// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> The release status of a phone number. </summary>
    public readonly partial struct PhoneNumberReleaseStatus : IEquatable<PhoneNumberReleaseStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PhoneNumberReleaseStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberReleaseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string SuccessValue = "Success";
        private const string ErrorValue = "Error";
        private const string InProgressValue = "InProgress";

        /// <summary> Pending. </summary>
        public static PhoneNumberReleaseStatus Pending { get; } = new PhoneNumberReleaseStatus(PendingValue);
        /// <summary> Success. </summary>
        public static PhoneNumberReleaseStatus Success { get; } = new PhoneNumberReleaseStatus(SuccessValue);
        /// <summary> Error. </summary>
        public static PhoneNumberReleaseStatus Error { get; } = new PhoneNumberReleaseStatus(ErrorValue);
        /// <summary> InProgress. </summary>
        public static PhoneNumberReleaseStatus InProgress { get; } = new PhoneNumberReleaseStatus(InProgressValue);
        /// <summary> Determines if two <see cref="PhoneNumberReleaseStatus"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberReleaseStatus left, PhoneNumberReleaseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberReleaseStatus"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberReleaseStatus left, PhoneNumberReleaseStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PhoneNumberReleaseStatus"/>. </summary>
        public static implicit operator PhoneNumberReleaseStatus(string value) => new PhoneNumberReleaseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberReleaseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberReleaseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}