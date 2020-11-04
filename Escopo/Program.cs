using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    class Programa
    {
        static void Main(String[] args)
        {
            Console.WriteLine("testando condicionais");

            int idade = 16;
            
            bool acompanhado = true;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }
            Console.ReadLine();
        }
    
    }
}