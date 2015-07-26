namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout formatter)
            : base(formatter)
        {
        }

        public override void Append(DateTime date, ReportLevel level, string message)
        {
            if (level < this.ReportLevel)
            {
                return;
            }

            string output = this.Formatter.Format(date, level, message);

            Console.WriteLine(output);
        }
    }
}
