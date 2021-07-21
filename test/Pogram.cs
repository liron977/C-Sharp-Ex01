/*The program prints 
*****
 ***
  *
 ***
*****

*/
namespace B20_Ex01_02
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            PrintSandMachine(8);
        }

        // function to print sand machine
        public static void PrintSandMachine(int i_Lines)
        {
            PrintSandMachineRec(i_Lines, i_Lines);
        }

        // recursive function to print sand machine
        public static void PrintSandMachineRec(int i_AsteriskNum, int i_Lines)
        {
            StringBuilder str = new StringBuilder();

            if (i_AsteriskNum == 1)
            {
                for (int i = 0; i < (i_Lines - 1) / 2; i++)
                {
                    str.Append(" ");
                }

                str.Append("*");
                Console.WriteLine(str);
                return;
            }

            for (int i = 0; i < (i_Lines - i_AsteriskNum) / 2; i++)
            {
                str.Append(" ");
            }

            for (int i = 0; i < i_AsteriskNum; i++)
            {
                str.Append("*");
            }

            Console.WriteLine(str);
            PrintSandMachineRec(i_AsteriskNum - 2, i_Lines);
            Console.WriteLine(str);
        }
    }
}