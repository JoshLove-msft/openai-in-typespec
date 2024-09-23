// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalMessageDeltaContentImageFileObjectImageFileDetail : IEquatable<InternalMessageDeltaContentImageFileObjectImageFileDetail>
    {
        private readonly string _value;
        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        public InternalMessageDeltaContentImageFileObjectImageFileDetail(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalMessageDeltaContentImageFileObjectImageFileDetail Auto { get; } = new InternalMessageDeltaContentImageFileObjectImageFileDetail(AutoValue);

        public static InternalMessageDeltaContentImageFileObjectImageFileDetail Low { get; } = new InternalMessageDeltaContentImageFileObjectImageFileDetail(LowValue);

        public static InternalMessageDeltaContentImageFileObjectImageFileDetail High { get; } = new InternalMessageDeltaContentImageFileObjectImageFileDetail(HighValue);

        public static bool operator ==(InternalMessageDeltaContentImageFileObjectImageFileDetail left, InternalMessageDeltaContentImageFileObjectImageFileDetail right) => left.Equals(right);

        public static bool operator !=(InternalMessageDeltaContentImageFileObjectImageFileDetail left, InternalMessageDeltaContentImageFileObjectImageFileDetail right) => !left.Equals(right);

        public static implicit operator InternalMessageDeltaContentImageFileObjectImageFileDetail(string value) => new InternalMessageDeltaContentImageFileObjectImageFileDetail(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalMessageDeltaContentImageFileObjectImageFileDetail other && Equals(other);

        public bool Equals(InternalMessageDeltaContentImageFileObjectImageFileDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
