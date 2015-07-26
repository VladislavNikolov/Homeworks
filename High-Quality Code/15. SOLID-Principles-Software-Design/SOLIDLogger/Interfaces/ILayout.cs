namespace SOLIDLogger.Interfaces
{
    using System;

    public interface ILayout
    {
        string Format(DateTime date, ReportLevel level, string message);
    }
}
