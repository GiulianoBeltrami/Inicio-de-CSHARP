using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            //int contagemMes = 1;

             /*
              while (contagemMes<=12)
             {
                 valorInvestido = valorInvestido + valorInvestido * 0.0036;
                 Console.WriteLine("Após " + contagemMes +" meses, você terá: R$" + valorInvestido);
                 contagemMes++;
             }
            */
            for (int contagemMes=1; contagemMes <= 12; contagemMes++) 
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após "+contagemMes+" meses, você terá: R$"+valorInvestido);
            } 
            



            Console.ReadLine();
        }
    }
}
