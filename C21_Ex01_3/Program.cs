using System;

namespace C21_Ex01_3
{
    class Program
    {
        public static void Main()
        {
            printSandMachine();
        }

        private static void printSandMachine()
        {
            int sandMachineHeight = getUserInput();

            if(sandMachineHeight % 2 == 0)
            {
                sandMachineHeight--;
            }

            C21_Ex01_02.Program.PrintSandMachine(sandMachineHeight);
        }

        private static int getUserInput()
        {
            bool isValidInput = false;
            string userInput = String.Empty;

            while(!isValidInput)
            {
                Console.WriteLine("Please enter the height of the sand machine:");
                userInput = Console.ReadLine();
                isValidInput = isInputContainsOnlyNumbers(userInput);
                if(!isValidInput)
                {
                    Console.WriteLine("Invalid input,the height should contains only numbers");
                }
            }

            Console.Write(Environment.NewLine);
            return int.Parse(userInput);
        }

        private static bool isInputContainsOnlyNumbers(string i_UserInput)
        {
            bool isValidHeight = true;

            for(int i = 0; i < i_UserInput.Length && isValidHeight; i++)
            {
                isValidHeight = i_UserInput[i] >= '0' && i_UserInput[i] <= '9';
            }

            return isValidHeight;
        }
    }
}