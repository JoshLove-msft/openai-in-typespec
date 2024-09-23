// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject : RunStepUpdateCodeInterpreterOutput
    {
        internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(int index) : base("logs")
        {
            Index = index;
        }

        internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(int index, string logs, string @type, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(@type, additionalBinaryDataProperties)
        {
            Index = index;
            Logs = logs;
        }

        public int Index { get; set; }
    }
}
