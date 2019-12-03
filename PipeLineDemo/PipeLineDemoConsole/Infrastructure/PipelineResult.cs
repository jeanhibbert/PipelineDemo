using System.Collections.Generic;

namespace PipeLineDemoConsole.Infrastructure
{
    public class PipelineResult
    {
        private List<PipelineStepResult> _stepResults = new List<PipelineStepResult>();
        public PipelineResult AddStepResult(PipelineStepResult stepResult)
        {
            _stepResults.Add(stepResult);
            return this;
        }
    }
}