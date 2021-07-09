using System;
using System.Threading.Channels;
using SOLID.Appenders;
using SOLID.Layouts;
using SOLID.Loggers;

namespace SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var layout = new XMLLayout();
            var consoleAppender = new ConsoleAppender(layout);

            var file = new LogFile();
            var fileAppender = new FileAppender(layout, file);

            //var logger = new Logger(consoleAppender, fileAppender);
            var logger = new Logger(fileAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");


        }
    }
}
