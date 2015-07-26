namespace SOLIDLogger.Interfaces
{
    using System;

    public interface IAppender
    {
        ILayout Formatter { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(DateTime date, ReportLevel level, string message);
    }
}
