using System;
using System.Text;

namespace C21_Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            PrintSandMachine(5);
        }

        public static void PrintSandMachine(int i_Height)
        {
            PrintSandMachineRecursion(i_Height, i_Height);
        }

        public static void PrintSandMachineRecursion(int i_AsteriskNumberToPrint, int i_Height)
        {
            StringBuilder str = new StringBuilder();
            if(i_AsteriskNumberToPrint == 1)
            {
                str.Append(' ', ((i_Height - 1) / 2));
                str.Append("*");
                Console.WriteLine(str);
                return;
            }

            str.Append(' ', ((i_Height - i_AsteriskNumberToPrint) / 2));
            str.Append('*', i_AsteriskNumberToPrint);

            Console.WriteLine(str);
            PrintSandMachineRecursion(i_AsteriskNumberToPrint - 2, i_Height);
            Console.WriteLine(str);
        }
    }
}