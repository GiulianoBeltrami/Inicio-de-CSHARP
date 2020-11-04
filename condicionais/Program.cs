using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 20, quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Maior que 18, pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Pode entrar pois está acompanhado.");
                }
                else
                {
                    Console.WriteLine("Menor que 18, não pode entrar.");
                }

            }
            Console.ReadLine();
        }
    }
}
