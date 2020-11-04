using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investlongprazo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0, fatorRendimento = 1.0036;

            for (int contagemAno = 1; contagemAno <= 5; contagemAno++)
            {
                for (int contagemMes = 1; contagemMes <= 12; contagemMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("No final você terá: R$" + valorInvestido);



            Console.ReadLine();
        }
    }
}
