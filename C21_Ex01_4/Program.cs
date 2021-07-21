using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex01_4
{
    class Program
    {
        static void Main()
        {

        }

        private static int getUserInput()
        {
            bool isValidInput = false;
            string userInput = string.Empty;
            while (!isValidInput)
            {
                Console.WriteLine("Please enter the height of the sand machine:");
                userInput = Console.ReadLine();
                isValidInput = isConstantInput(userInput);
                if (!isValidInput)
                {
                    Console.WriteLine("");
                }
            }
            Console.Write(Environment.NewLine);
            return int.Parse(userInput);
        }

        private static bool isValidString(string i_UserInput)
        {
            char firstInputChar = i_UserInput[0];
            bool isValidInput = false;
            if (firstInputChar >= 'a' && firstInputChar <= 'z')
            {
                isValidInput=isConstantInput(i_UserInput, 'a', 'z');
            }
            else if (firstInputChar >= 'A' && firstInputChar <= 'Z')
            {
                isValidInput= isConstantInput(i_UserInput, 'A', 'Z');
            }
            else if (firstInputChar >= '0' && firstInputChar <= '9')
            {
                isValidInput=isConstantInput(i_UserInput, '0', '9');
            }

            return isValidInput;
        }
        private static bool isConstantInput(string i_UserInput, char i_CharBeginningRange, char i_CharEndRange)
        {
            bool isValidInput = true;
            for (int i = 0; i < i_UserInput.Length && isValidInput; i++)
            {
                isValidInput = i_UserInput[i] >= i_CharBeginningRange && i_UserInput[i] <= i_CharEndRange;

            }

            return isValidInput;
        }

    }

}
