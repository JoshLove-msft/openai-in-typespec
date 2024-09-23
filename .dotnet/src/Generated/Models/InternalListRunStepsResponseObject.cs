// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalListRunStepsResponseObject : IEquatable<InternalListRunStepsResponseObject>
    {
        private readonly string _value;
        private const string ListValue = "list";

        public InternalListRunStepsResponseObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalListRunStepsResponseObject List { get; } = new InternalListRunStepsResponseObject(ListValue);

        public static bool operator ==(InternalListRunStepsResponseObject left, InternalListRunStepsResponseObject right) => left.Equals(right);

        public static bool operator !=(InternalListRunStepsResponseObject left, InternalListRunStepsResponseObject right) => !left.Equals(right);

        public static implicit operator InternalListRunStepsResponseObject(string value) => new InternalListRunStepsResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListRunStepsResponseObject other && Equals(other);

        public bool Equals(InternalListRunStepsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
