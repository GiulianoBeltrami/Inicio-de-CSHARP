using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lacosWhile
{
    class Programa
    {
        static void Main(String[] args)
        {
            for (int fator1 = 1; fator1<=10;fator1++)
            {
                for (int fator2 = 1;fator2<=10;fator2++)
                {
                    Console.WriteLine(fator1 +" * "+fator2+" = "+ fator1*fator2);
                    Console.WriteLine();
                }
            }
               

            Console.ReadLine();
        }

    }
}
