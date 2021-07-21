using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex01_02
{
    class Program
    {
        private static char[] m_AsterisksArray = new Char[5];
        static void Main()
        {
            initTheAsterisksArray();
            printAsterisksSandMachine(5,4,0);
        }

        private static void initTheAsterisksArray()
        {
            for (int i = 0; i < 5; i++)
            {
                m_AsterisksArray[i] = '*';

            }
        }

        private static void printAsterisksSandMachine(int SandMachineHeight, int counterFromTheArrayBeginning, int counterFromTheArrayEnd)
        {
            if (SandMachineHeight == 1||( counterFromTheArrayBeginning==1&& counterFromTheArrayEnd==1))
            {
                //printAsterisksArray();
                return;
            }
            else
            {
                printAsterisksArray();
                Console.WriteLine();
                m_AsterisksArray[counterFromTheArrayBeginning] = ' ';
                m_AsterisksArray[counterFromTheArrayEnd] = ' ';
            }

            printAsterisksSandMachine(SandMachineHeight - 1, counterFromTheArrayBeginning - 1, counterFromTheArrayEnd + 1);
            m_AsterisksArray[counterFromTheArrayBeginning] = '*';
            m_AsterisksArray[counterFromTheArrayEnd] = '*';
            printAsterisksArray();
            Console.WriteLine();
        }

        private static void printAsterisksArray()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(m_AsterisksArray[i]);
            }

           


        }
    }
}
