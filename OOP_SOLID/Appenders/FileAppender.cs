using System;
using System.IO;
using SOLID.Enums;
using SOLID.Layouts;
using SOLID.Loggers;

namespace SOLID.Appenders
{
    public class FileAppender : Appender

    {
        private readonly ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message) +
                             Environment.NewLine;

            this.logFile.Write(content);
            //File.AppendAllText("../../../log.txt", content);
        }
    }
}