// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Images
{
    public partial class ImageEditOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ImageEditOptions(Images.OpenAI.Images.GeneratedImageSize<GeneratedImageSize>? size, Images.OpenAI.Images.GeneratedImageFormat<Images.GeneratedImageFormat>? responseFormat, string endUserId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Size = size;
            ResponseFormat = responseFormat;
            EndUserId = endUserId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }
    }
}
