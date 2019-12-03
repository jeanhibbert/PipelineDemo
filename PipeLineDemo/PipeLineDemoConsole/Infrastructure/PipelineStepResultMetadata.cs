using System;

namespace PipeLineDemoConsole.Infrastructure
{
    public class PipelineStepResultMetadata
    {
        public string StepName { get; set; }
        public string Message { get; set; }
        public TimeSpan Duration { get; set; }
    }
}