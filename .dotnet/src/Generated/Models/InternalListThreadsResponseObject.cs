// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalListThreadsResponseObject : IEquatable<InternalListThreadsResponseObject>
    {
        private readonly string _value;
        private const string ListValue = "list";

        public InternalListThreadsResponseObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalListThreadsResponseObject List { get; } = new InternalListThreadsResponseObject(ListValue);

        public static bool operator ==(InternalListThreadsResponseObject left, InternalListThreadsResponseObject right) => left.Equals(right);

        public static bool operator !=(InternalListThreadsResponseObject left, InternalListThreadsResponseObject right) => !left.Equals(right);

        public static implicit operator InternalListThreadsResponseObject(string value) => new InternalListThreadsResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListThreadsResponseObject other && Equals(other);

        public bool Equals(InternalListThreadsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
