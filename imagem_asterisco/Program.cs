using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imagem_asterisco
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contadorLinha=1; contadorLinha <=10;contadorLinha++)
            {
               for(int contadorAsterisco = 1; contadorAsterisco <= 10;contadorAsterisco++)
                {
                    Console.Write("*");
                    if (contadorAsterisco >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
