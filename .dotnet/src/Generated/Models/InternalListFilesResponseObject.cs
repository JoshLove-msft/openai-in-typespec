// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Files
{
    internal readonly partial struct InternalListFilesResponseObject : IEquatable<InternalListFilesResponseObject>
    {
        private readonly string _value;
        private const string ListValue = "list";

        public InternalListFilesResponseObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalListFilesResponseObject List { get; } = new InternalListFilesResponseObject(ListValue);

        public static bool operator ==(InternalListFilesResponseObject left, InternalListFilesResponseObject right) => left.Equals(right);

        public static bool operator !=(InternalListFilesResponseObject left, InternalListFilesResponseObject right) => !left.Equals(right);

        public static implicit operator InternalListFilesResponseObject(string value) => new InternalListFilesResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListFilesResponseObject other && Equals(other);

        public bool Equals(InternalListFilesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
