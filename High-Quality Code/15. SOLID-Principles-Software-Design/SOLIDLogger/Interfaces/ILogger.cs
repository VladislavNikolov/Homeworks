namespace SOLIDLogger.Interfaces
{
    using System.Collections.Generic;

    public interface ILogger
    {
        List<IAppender> Appenders { get; }

        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);
    }
}
