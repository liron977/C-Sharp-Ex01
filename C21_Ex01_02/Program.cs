using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex01_02
{
   public class Program
    {
        
        static void Main()
        {
            PrintSandMachine(5);
        }

        public static void PrintSandMachine(int i_Hight)
        {
            PrintSandMachineRecursion(i_Hight, i_Hight);
        }

        public static void PrintSandMachineRecursion(int i_AsteriskNumberToPrint, int i_Hight)
        {
            StringBuilder str = new StringBuilder();

            if (i_AsteriskNumberToPrint == 1)
            {
                str.Append(' ', ((i_Hight - 1) / 2));
                str.Append("*");
                Console.WriteLine(str);
                return;
            }
            str.Append(' ', ((i_Hight - i_AsteriskNumberToPrint) / 2));
            str.Append('*', i_AsteriskNumberToPrint);
                
            Console.WriteLine(str);
            PrintSandMachineRecursion(i_AsteriskNumberToPrint - 2, i_Hight);
            Console.WriteLine(str);
        }
    }


}
