// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Files
{
    internal readonly partial struct InternalDeleteFileResponseObject : IEquatable<InternalDeleteFileResponseObject>
    {
        private readonly string _value;
        private const string FileValue = "file";

        public InternalDeleteFileResponseObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalDeleteFileResponseObject File { get; } = new InternalDeleteFileResponseObject(FileValue);

        public static bool operator ==(InternalDeleteFileResponseObject left, InternalDeleteFileResponseObject right) => left.Equals(right);

        public static bool operator !=(InternalDeleteFileResponseObject left, InternalDeleteFileResponseObject right) => !left.Equals(right);

        public static implicit operator InternalDeleteFileResponseObject(string value) => new InternalDeleteFileResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalDeleteFileResponseObject other && Equals(other);

        public bool Equals(InternalDeleteFileResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
