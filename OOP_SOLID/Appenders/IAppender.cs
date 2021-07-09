using SOLID.Enums;

namespace SOLID.Appenders
{
    public interface IAppender
    {
        void Append(string date, ReportLevel reportLevel, string message);
    }
}