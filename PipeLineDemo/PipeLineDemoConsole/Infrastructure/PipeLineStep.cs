using System;
using System.Collections.Generic;
using System.Text;

namespace PipeLineDemoConsole.Infrastructure
{
    public abstract class PipeLineStep<T> : IPipelineStep<T>
    {

        public virtual void PreConditions(T context)
        {
            // default is no validation
        }

        public abstract void Execute(T context);

        public virtual void PostConditions(T context)
        {
            // default is no validation
        }

        public PipelineStepResultMetadata GetStepMetadata(TimeSpan duration)
        {
            return new PipelineStepResultMetadata
            {
                StepName = GetType().Name,
                Duration = duration
            };
        }
    }
}
