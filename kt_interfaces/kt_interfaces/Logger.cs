using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces
{
    public class Logger
    {
        public Logger(ConsoleColor logTextColor)
        {
            LogTextColor = logTextColor;
        }

        public ConsoleColor LogTextColor { get; }

        public void PrintLog(string log)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = LogTextColor;
            Console.WriteLine(log);
            Console.ForegroundColor = defaultColor;
        }
    }
}
