// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Images
{
    internal readonly partial struct InternalCreateImageEditRequestModel : IEquatable<InternalCreateImageEditRequestModel>
    {
        private readonly string _value;
        private const string DallE2Value = "dall-e-2";

        public InternalCreateImageEditRequestModel(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalCreateImageEditRequestModel DallE2 { get; } = new InternalCreateImageEditRequestModel(DallE2Value);

        public static bool operator ==(InternalCreateImageEditRequestModel left, InternalCreateImageEditRequestModel right) => left.Equals(right);

        public static bool operator !=(InternalCreateImageEditRequestModel left, InternalCreateImageEditRequestModel right) => !left.Equals(right);

        public static implicit operator InternalCreateImageEditRequestModel(string value) => new InternalCreateImageEditRequestModel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateImageEditRequestModel other && Equals(other);

        public bool Equals(InternalCreateImageEditRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
