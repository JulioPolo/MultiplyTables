using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTables
{
    class Multiply
    {
        public void CreateTables()
        {
            Console.Write("\t 1\t 2\t 3\t 4\t 5\t 6\t 7\t 8\t 9");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("\t{0,2}", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t{0,2}", i * j);
                }
                
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Developed by: Julio Polo");
            Console.WriteLine("Twitter : @Arpojul");
        }
    }
}
