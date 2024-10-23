using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo10
{
    internal class Helpers
    {
        public static void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public static void MyLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
