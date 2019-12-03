using PipeLineDemoConsole.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PipeLineDemoConsole.DataLoaderPipeLine.Steps
{
    public class LoadDataStep : PipeLineStep<DataLoaderContext>
    {
        public override void PreConditions(DataLoaderContext context)
        {
            base.PreConditions(context);
        }

        public override void Execute(DataLoaderContext context)
        {
            Console.WriteLine($"Data Loaded - {context.CorrelationContextId}");
        }

        public override void PostConditions(DataLoaderContext context)
        {
            base.PostConditions(context);
        }

    }
}
