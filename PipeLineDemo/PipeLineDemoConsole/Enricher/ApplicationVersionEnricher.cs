using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PipeLineDemoConsole.Enricher
{
    public class ApplicationVersionEnricher : ILogEventEnricher
    {
        private static readonly Version AppVersion;

        static ApplicationVersionEnricher()
        {
            AppVersion = Assembly.GetExecutingAssembly().GetName().Version;
        }

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var appVersionProperty = propertyFactory.CreateProperty("AppVersion", AppVersion.ToString());
            logEvent.AddPropertyIfAbsent(appVersionProperty);
        }
    }
}
