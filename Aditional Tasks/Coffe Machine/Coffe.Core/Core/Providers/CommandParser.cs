using Coffee.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Coffee.Core.Providers
{
    public class CommandParser : ICommandParser
    {
        private const string MAIN_SPLIT_SYMBOL = " ";
        //private const string COMMENT_OPEN_SYMBOL = "{{";
        //private const string COMMENT_CLOSE_SYMBOL = "}}";

        public string ParseCommand(string fullCommand)
        {
            string commandName = fullCommand.Split(" ")[0];
            return commandName;
        }

        public List<string> ParseParameters(string fullCommand)
        {
            int indexOfFirstSeparator = fullCommand.IndexOf(MAIN_SPLIT_SYMBOL);
            //int indexOfOpenComment = fullCommand.IndexOf(COMMENT_OPEN_SYMBOL);
            //int indexOfCloseComment = fullCommand.IndexOf(COMMENT_CLOSE_SYMBOL);
            List<string> parameters = new List<string>();
            //if (indexOfOpenComment >= 0)
            //{
            //     var start = indexOfOpenComment + COMMENT_OPEN_SYMBOL.Length;
            //     var end = indexOfCloseComment - start;
            //     parameters.Add(fullCommand.Substring(start, end));


            //    Regex rgx = new Regex("\\{\\{.+(?=}})}}");
            //    fullCommand = rgx.Replace(fullCommand, "");
            //    // fullCommand = fullCommand.ReplaceAll("\\{\\{.+(?=}})}}", "");
            //}

            List<String> result = new List<string>(fullCommand.Substring(indexOfFirstSeparator + 1).Split(MAIN_SPLIT_SYMBOL));
            result.RemoveAll(s => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s));
            parameters.AddRange(result);
            return parameters;
        }
    }
}
