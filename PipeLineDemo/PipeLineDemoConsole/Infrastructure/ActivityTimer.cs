using System;
using System.Diagnostics;

namespace PipeLineDemoConsole.Infrastructure
{
    internal class ActivityTimer : IDisposable
    {
        private readonly Stopwatch _stopwatch;

        public TimeSpan Duration { get { return _stopwatch.Elapsed; } }

        public ActivityTimer()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
        }
    }
}