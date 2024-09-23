// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.LegacyCompletions
{
    internal readonly partial struct InternalCreateCompletionRequestModel : IEquatable<InternalCreateCompletionRequestModel>
    {
        private readonly string _value;
        private const string Gpt35TurboInstructValue = "gpt-3.5-turbo-instruct";
        private const string Davinci002Value = "davinci-002";
        private const string Babbage002Value = "babbage-002";

        public InternalCreateCompletionRequestModel(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalCreateCompletionRequestModel Gpt35TurboInstruct { get; } = new InternalCreateCompletionRequestModel(Gpt35TurboInstructValue);

        public static InternalCreateCompletionRequestModel Davinci002 { get; } = new InternalCreateCompletionRequestModel(Davinci002Value);

        public static InternalCreateCompletionRequestModel Babbage002 { get; } = new InternalCreateCompletionRequestModel(Babbage002Value);

        public static bool operator ==(InternalCreateCompletionRequestModel left, InternalCreateCompletionRequestModel right) => left.Equals(right);

        public static bool operator !=(InternalCreateCompletionRequestModel left, InternalCreateCompletionRequestModel right) => !left.Equals(right);

        public static implicit operator InternalCreateCompletionRequestModel(string value) => new InternalCreateCompletionRequestModel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateCompletionRequestModel other && Equals(other);

        public bool Equals(InternalCreateCompletionRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
