namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout formatter)
        {
            this.Formatter = formatter;
        }

        public ILayout Formatter { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(DateTime date, ReportLevel level, string message);
    }
}
