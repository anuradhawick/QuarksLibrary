using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuarksLibrary.SearchAlgorithms
{
    class RegexGenerator
    {
        private RegexGenerator() { }
        public static string generateRegexString(string userInput)
        {
            char[] delim = { ' ','/','+' };
            string[] input = userInput.Split(delim);
            string output = "";
            string temp;
            for (int i = 0; i < input.Length; i++)
            {
                string s = input[i];
                if (s.Equals("") | s.Equals(" "))
                {
                    continue;
                }
                //avoiding the,of,in,and,or
                else if (s.ToLower().Equals("or") | s.ToLower().Equals("and") | s.ToLower().Equals("of") | s.ToLower().Equals("the") | s.ToLower().Equals("in"))
                {
                    continue;
                }
                else
                {
                    temp = "(" + s.ToLower() + "+" + ")";
                }
                if (i != input.Length - 1)
                {
                    temp += "|";
                }
                output += temp;
            }
            return output;
        }
    }
}
