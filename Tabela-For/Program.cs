using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.WriteLine(a * b + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
