using System;
using System.Text;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder htmlOutput = new StringBuilder();

            string input = Console.ReadLine();
            AddTheTittle(htmlOutput, input);

            input = Console.ReadLine();
            AddTheContent(htmlOutput, input);

            while ((input = Console.ReadLine()) != "end of comments")
            {
                AddTheComment(htmlOutput, input);
            }

            Console.WriteLine(htmlOutput.ToString());
        }

        private static void AddTheComment(StringBuilder htmlOutput, string input)
        {
            htmlOutput.AppendLine("<div>");
            htmlOutput.AppendLine($"    {input}");
            htmlOutput.AppendLine("</div>");
        }

        private static void AddTheContent(StringBuilder htmlOutput, string input)
        {
            htmlOutput.AppendLine("<article>");
            htmlOutput.AppendLine($"    {input}");
            htmlOutput.AppendLine("</article>");
        }

        private static void AddTheTittle(StringBuilder htmlOutput, string input)
        {
            htmlOutput.AppendLine("<h1>");
            htmlOutput.AppendLine($"    {input}");
            htmlOutput.AppendLine("</h1>");
        }
    }
}
