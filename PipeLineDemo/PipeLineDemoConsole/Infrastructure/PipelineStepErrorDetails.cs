using System;

namespace PipeLineDemoConsole.Infrastructure
{
    internal class PipelineStepErrorDetails
    {
        public Exception Exception { get; set; }
        public object Message { get; set; }
    }
}