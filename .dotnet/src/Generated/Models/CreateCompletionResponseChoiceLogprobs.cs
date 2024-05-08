// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.LegacyCompletions
{
    /// <summary> The CreateCompletionResponseChoiceLogprobs. </summary>
    internal partial class CreateCompletionResponseChoiceLogprobs
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoiceLogprobs"/>. </summary>
        internal CreateCompletionResponseChoiceLogprobs()
        {
            TextOffset = new ChangeTrackingList<int>();
            TokenLogprobs = new ChangeTrackingList<float>();
            Tokens = new ChangeTrackingList<string>();
            TopLogprobs = new ChangeTrackingList<IDictionary<string, float>>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoiceLogprobs"/>. </summary>
        /// <param name="textOffset"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="tokens"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateCompletionResponseChoiceLogprobs(IReadOnlyList<int> textOffset, IReadOnlyList<float> tokenLogprobs, IReadOnlyList<string> tokens, IReadOnlyList<IDictionary<string, float>> topLogprobs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TextOffset = textOffset;
            TokenLogprobs = tokenLogprobs;
            Tokens = tokens;
            TopLogprobs = topLogprobs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the text offset. </summary>
        public IReadOnlyList<int> TextOffset { get; }
        /// <summary> Gets the token logprobs. </summary>
        public IReadOnlyList<float> TokenLogprobs { get; }
        /// <summary> Gets the tokens. </summary>
        public IReadOnlyList<string> Tokens { get; }
        /// <summary> Gets the top logprobs. </summary>
        public IReadOnlyList<IDictionary<string, float>> TopLogprobs { get; }
    }
}
