using System;
using System.Collections.Generic;
using System.Text;

namespace PipeLineDemoConsole.Infrastructure
{
    public interface IPipeline<T>
    {
        PipelineResult Execute(T context);

        IPipeline<T> AddStep<TStep>(TStep step) where TStep : IPipelineStep<T>;
    }
}
