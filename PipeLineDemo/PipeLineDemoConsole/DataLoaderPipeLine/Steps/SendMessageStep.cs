using PipeLineDemoConsole.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PipeLineDemoConsole.DataLoaderPipeLine.Steps
{
    public class SendMessageStep : PipeLineStep<DataLoaderContext>
    {
        public override void Execute(DataLoaderContext context)
        {
            Console.WriteLine($"Message sent - {context.CorrelationContextId}");
        }
    }
}
