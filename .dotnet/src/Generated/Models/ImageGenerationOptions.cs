// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Images
{
    public partial class ImageGenerationOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ImageGenerationOptions(GeneratedImageQuality? quality, GeneratedImageFormat? responseFormat, GeneratedImageSize? size, GeneratedImageStyle? style, InternalCreateImageRequestModel? model, string prompt, long? n, string endUserId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Quality = quality;
            ResponseFormat = responseFormat;
            Size = size;
            Style = style;
            Model = model;
            Prompt = prompt;
            N = n;
            EndUserId = endUserId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public GeneratedImageQuality? Quality { get; set; }

        public GeneratedImageFormat? ResponseFormat { get; set; }

        public GeneratedImageSize? Size { get; set; }

        public GeneratedImageStyle? Style { get; set; }
    }
}
