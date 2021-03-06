using SOLID.Enums;
using SOLID.Layouts;

namespace SOLID.Appenders
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public abstract void Append(string date, ReportLevel reportLevel, string message);

    }
}