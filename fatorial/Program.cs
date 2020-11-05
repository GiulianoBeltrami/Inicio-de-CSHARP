using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial =  1;

            for (int contador=1; contador<=10;contador++)
            {
                fatorial = fatorial * contador;
                Console.WriteLine("O fatorial de : "+contador+" é  "+fatorial);
            }


            Console.ReadLine();
        }
    }
}
