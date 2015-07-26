namespace SOLIDLogger.Layouts
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel level, string message)
        {
            return string.Format("{0} - {1} - {2}", date, level, message);
        }
    }
}
