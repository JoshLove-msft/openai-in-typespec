// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Models
{
    internal readonly partial struct InternalModelObject : IEquatable<InternalModelObject>
    {
        private readonly string _value;
        private const string ModelValue = "model";

        public InternalModelObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalModelObject Model { get; } = new InternalModelObject(ModelValue);

        public static bool operator ==(InternalModelObject left, InternalModelObject right) => left.Equals(right);

        public static bool operator !=(InternalModelObject left, InternalModelObject right) => !left.Equals(right);

        public static implicit operator InternalModelObject(string value) => new InternalModelObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalModelObject other && Equals(other);

        public bool Equals(InternalModelObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
