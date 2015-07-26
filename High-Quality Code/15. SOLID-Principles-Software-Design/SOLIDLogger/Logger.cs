namespace SOLIDLogger
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public List<IAppender> Appenders { get; set; }

        public void Info(string message)
        {
            this.Log(ReportLevel.Info, message);
        }

        public void Warn(string message)
        {
            this.Log(ReportLevel.Warn, message);
        }

        public void Error(string message)
        {
            this.Log(ReportLevel.Error, message);
        }

        public void Critical(string message)
        {
            this.Log(ReportLevel.Critical, message);
        }

        public void Fatal(string message)
        {
            this.Log(ReportLevel.Fatal, message);
        }

        private void Log(ReportLevel level, string message)
        {
            var date = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.Append(date, level, message);
            }
        }
    }
}
