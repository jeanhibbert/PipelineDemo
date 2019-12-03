using PipeLineDemoConsole.DataLoaderPipeLine;
using PipeLineDemoConsole.DataLoaderPipeLine.Steps;
using PipeLineDemoConsole.Infrastructure;
using System;

namespace PipeLineDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = new PipeLine<DataLoaderContext>()
                .AddStep(new LoadDataStep())
                .AddStep(new SendMessageStep());

            var context = new DataLoaderContext { CorrelationContextId = Guid.NewGuid() };

            var result = pipeline.Execute(context);

            Console.ReadKey();
        }
    }
}
