using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UpdateLibrary());
            //Application.Run(new QuarksMain());
            //Application.Run(new UserCheckOut("name","Auth","123"));
            //Console.WriteLine(SearchAlgorithms.RegexGenerator.generateRegexString("Adventures  of sherlock holmes"));
        }
    }
}
