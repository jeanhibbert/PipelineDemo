using System;
using System.Collections.Generic;
using System.Text;

namespace PipeLineDemoConsole.Infrastructure
{
    public class PipeLine<T> : IPipeline<T>
    {
        private readonly List<IPipelineStep<T>> _activeSteps;

        public PipeLine()
        {
            _activeSteps = new List<IPipelineStep<T>>();
        }

        public IPipeline<T> AddStep<TStep>(TStep step) where TStep : IPipelineStep<T>
        {
            _activeSteps.Add(step);
            return this;
        }

        public PipelineResult Execute(T context)
        {
            var result = new PipelineResult();

            foreach (var step in _activeSteps)
            {
                var timer = new ActivityTimer();

                try
                {
                    step.PreConditions(context);
                    step.Execute(context);
                    step.PostConditions(context);
                    result.AddStepResult(PipelineStepResult.Success(step.GetStepMetadata(timer.Duration)));
                    // STANDARD LOGGING GOES HERE                        
                }
                catch (Exception ex)
                {
                    result.AddStepResult(PipelineStepResult.Failure(step.GetStepMetadata(timer.Duration), ex));
                    // STANDARD LOGGING GOES HERE
                }
                finally
                {
                    timer.Dispose();
                }
            }

            return result;
        }
    }
}
