using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthCoffee.LogProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var logLocator = new LogLocator("C:\\Program Files\\Microsoft Learning\\20483\\Allfiles\\Mod06\\Democode\\Data\\Logs\\");
            var logCombiner = new LogCombiner(logLocator);

            logCombiner.CombineLogs("C:\\Program Files\\Microsoft Learning\\20483\\Allfiles\\Mod06\\Democode\\Data\\Logs\\CombinedLog.txt");

        }
    }
}
