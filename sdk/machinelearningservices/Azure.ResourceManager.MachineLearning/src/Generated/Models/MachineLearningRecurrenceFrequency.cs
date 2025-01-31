// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Enum to describe the frequency of a recurrence schedule
    /// Serialized Name: RecurrenceFrequency
    /// </summary>
    public readonly partial struct MachineLearningRecurrenceFrequency : IEquatable<MachineLearningRecurrenceFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningRecurrenceFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningRecurrenceFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MinuteValue = "Minute";
        private const string HourValue = "Hour";
        private const string DayValue = "Day";
        private const string WeekValue = "Week";
        private const string MonthValue = "Month";

        /// <summary>
        /// Minute frequency
        /// Serialized Name: RecurrenceFrequency.Minute
        /// </summary>
        public static MachineLearningRecurrenceFrequency Minute { get; } = new MachineLearningRecurrenceFrequency(MinuteValue);
        /// <summary>
        /// Hour frequency
        /// Serialized Name: RecurrenceFrequency.Hour
        /// </summary>
        public static MachineLearningRecurrenceFrequency Hour { get; } = new MachineLearningRecurrenceFrequency(HourValue);
        /// <summary>
        /// Day frequency
        /// Serialized Name: RecurrenceFrequency.Day
        /// </summary>
        public static MachineLearningRecurrenceFrequency Day { get; } = new MachineLearningRecurrenceFrequency(DayValue);
        /// <summary>
        /// Week frequency
        /// Serialized Name: RecurrenceFrequency.Week
        /// </summary>
        public static MachineLearningRecurrenceFrequency Week { get; } = new MachineLearningRecurrenceFrequency(WeekValue);
        /// <summary>
        /// Month frequency
        /// Serialized Name: RecurrenceFrequency.Month
        /// </summary>
        public static MachineLearningRecurrenceFrequency Month { get; } = new MachineLearningRecurrenceFrequency(MonthValue);
        /// <summary> Determines if two <see cref="MachineLearningRecurrenceFrequency"/> values are the same. </summary>
        public static bool operator ==(MachineLearningRecurrenceFrequency left, MachineLearningRecurrenceFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningRecurrenceFrequency"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningRecurrenceFrequency left, MachineLearningRecurrenceFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningRecurrenceFrequency"/>. </summary>
        public static implicit operator MachineLearningRecurrenceFrequency(string value) => new MachineLearningRecurrenceFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningRecurrenceFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningRecurrenceFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
