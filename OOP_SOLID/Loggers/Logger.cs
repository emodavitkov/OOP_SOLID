using System.Linq;
using SOLID.Appenders;
using SOLID.Enums;

namespace SOLID.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;


        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }


        public void Info(string date, string message)
        {
            this.AppendToAppenders(date,ReportLevel.Info,message);
        }

        public void Error(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Error, message);
        }

        public void Fatal(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Fatal, message);
        }

        public void Critical(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Critical, message);
        }

        private void AppendToAppenders(string date, ReportLevel reportLevel, string message)
        {


            foreach (var appender in appenders)
            {
                appender.Append(date, reportLevel, message);
            }

        }
    }
}