using System;
using System.Collections.Generic;
using System.Text;

namespace PipeLineDemoConsole.Infrastructure
{
    public interface IPipelineStep<T>
    {
        void PreConditions(T context);
        void Execute(T context);
        void PostConditions(T context);

        PipelineStepResultMetadata GetStepMetadata(TimeSpan duration);
    }
}