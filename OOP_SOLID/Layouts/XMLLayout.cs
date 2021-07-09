using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SOLID.Layouts
{
    public class XMLLayout :ILayout
    {
        public string Template
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("<log>");
                sb.AppendLine(" <date>{0}</date> ");
                sb.AppendLine(" <level>{1}</level> ");
                sb.AppendLine(" <message>{2}</message> ");
                sb.AppendLine("</log>");



                return sb.ToString().TrimEnd();
            }


        }
    }
}