using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuarksLibrary.SearchAlgorithms
{
    class StringMatchFinder
    {
        private StringMatchFinder() { }
        public static bool matchStrings(string dbString, string userInput)
        {
            Regex reg = null;
            try
            {
                reg = new Regex(RegexGenerator.generateRegexString(userInput));
            }
            catch (Exception)
            {
                //do nothing
            }
            return (reg == null) ? false : reg.IsMatch(dbString.ToLower());
        }
    }
}
