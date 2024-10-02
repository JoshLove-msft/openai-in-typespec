// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Images
{
    public partial class GeneratedImage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal GeneratedImage()
        {
        }

        internal GeneratedImage(string revisedPrompt, BinaryData imageBytes, Uri imageUri, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            RevisedPrompt = revisedPrompt;
            ImageBytes = imageBytes;
            ImageUri = imageUri;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string RevisedPrompt { get; set; }
    }
}
