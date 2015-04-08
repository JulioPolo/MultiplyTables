using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply MyTables = new Multiply();

            MyTables.CreateTables();

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
