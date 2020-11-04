using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo textoss!!!!");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)120;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 120);
            Console.WriteLine(primeiraLetra);

            int ano = 2020;
            string texto = "curso de tecnologia " + ano;
            Console.WriteLine(texto);

            string cursos = 
 @"-Java
-Javascript
-Python";
            Console.WriteLine(cursos);

            Console.ReadLine();
        }
    }
}
