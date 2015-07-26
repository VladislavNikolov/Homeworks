namespace SOLIDLogger.Appenders
{
    using System;
    using System.IO;
    using Interfaces;

    class FileAppender : Appender
    {
        private readonly StreamWriter writer;

        public FileAppender(ILayout formatter, string path)
            : base(formatter)
        {
            this.Path = path;
            this.writer = new StreamWriter(this.Path);
        }

        public string Path { get; private set; }

        public override void Append(DateTime date, ReportLevel level, string message)
        {
            if (level < this.ReportLevel)
            {
                return;
            }

            string output = this.Formatter.Format(date, level, message);

            this.writer.WriteLine(output);
            this.writer.Flush();
        }

        public void Close()
        {
            this.writer.Close();
        }
    }
}
