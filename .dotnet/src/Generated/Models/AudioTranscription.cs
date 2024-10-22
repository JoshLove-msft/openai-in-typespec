// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Audio
{
    public partial class AudioTranscription
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal AudioTranscription(string language, string text, TimeSpan? duration)
        {
            Language = language;
            Text = text;
            Words = new ChangeTrackingList<TranscribedWord>();
            Segments = new ChangeTrackingList<TranscribedSegment>();
            Duration = duration;
        }

        internal AudioTranscription(string language, string text, IList<TranscribedWord> words, IList<TranscribedSegment> segments, InternalCreateTranscriptionResponseVerboseJsonTask task, TimeSpan? duration, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Language = language;
            Text = text;
            Words = words;
            Segments = segments;
            Task = task;
            Duration = duration;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Language { get; }

        public string Text { get; }

        public IList<TranscribedWord> Words { get; }

        public IList<TranscribedSegment> Segments { get; }
    }
}
