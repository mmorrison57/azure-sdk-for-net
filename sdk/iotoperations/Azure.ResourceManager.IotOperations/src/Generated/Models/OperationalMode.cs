// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> Mode properties. </summary>
    public readonly partial struct OperationalMode : IEquatable<OperationalMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled is equivalent to True. </summary>
        public static OperationalMode Enabled { get; } = new OperationalMode(EnabledValue);
        /// <summary> Disabled is equivalent to False. </summary>
        public static OperationalMode Disabled { get; } = new OperationalMode(DisabledValue);
        /// <summary> Determines if two <see cref="OperationalMode"/> values are the same. </summary>
        public static bool operator ==(OperationalMode left, OperationalMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalMode"/> values are not the same. </summary>
        public static bool operator !=(OperationalMode left, OperationalMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationalMode"/>. </summary>
        public static implicit operator OperationalMode(string value) => new OperationalMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
