using System;

namespace PipeLineDemoConsole.Infrastructure
{
    public class PipelineStepResult
    {
        public bool Successful { get; private set; }
        public string StepName { get; private set; }
        public string Message { get; private set; }
        internal PipelineStepErrorDetails FailureDetails { get; private set; }

        public static PipelineStepResult Success(PipelineStepResultMetadata metadata)
        {
            return new PipelineStepResult
            {
                Successful = true,
                StepName = metadata.StepName,
                Message = metadata.Message
            };
        }

        public static PipelineStepResult Failure(PipelineStepResultMetadata metadata, Exception exception)
        {
            return new PipelineStepResult
            {
                Successful = false,
                StepName = metadata.StepName,
                Message = metadata.Message ?? exception.Message,
                FailureDetails = new PipelineStepErrorDetails
                {
                    Exception = exception,
                    Message = exception.Message
                }
            };
        }
    }
}