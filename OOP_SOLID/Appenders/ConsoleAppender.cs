using System;
using SOLID.Enums;
using SOLID.Layouts;

namespace SOLID.Appenders
{
    public class ConsoleAppender:Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {

        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message);

            Console.WriteLine(content);
        }
    }
}