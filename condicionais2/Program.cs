using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16, quantidadePessoas = 3;

            if (idade >= 18 || quantidadePessoas >=2 )
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
            Console.ReadLine();
        }
    }
}

