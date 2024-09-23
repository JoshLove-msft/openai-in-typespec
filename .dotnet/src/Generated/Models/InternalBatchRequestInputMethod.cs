// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Batch
{
    internal readonly partial struct InternalBatchRequestInputMethod : IEquatable<InternalBatchRequestInputMethod>
    {
        private readonly string _value;
        private const string POSTValue = "POST";

        public InternalBatchRequestInputMethod(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalBatchRequestInputMethod POST { get; } = new InternalBatchRequestInputMethod(POSTValue);

        public static bool operator ==(InternalBatchRequestInputMethod left, InternalBatchRequestInputMethod right) => left.Equals(right);

        public static bool operator !=(InternalBatchRequestInputMethod left, InternalBatchRequestInputMethod right) => !left.Equals(right);

        public static implicit operator InternalBatchRequestInputMethod(string value) => new InternalBatchRequestInputMethod(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalBatchRequestInputMethod other && Equals(other);

        public bool Equals(InternalBatchRequestInputMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
