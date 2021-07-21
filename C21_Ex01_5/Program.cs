using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex01_5
{
    class Program
    {
        public const int k_LengthString = 9;
        static void Main()
        {
           
        }

        private static string getUserInput()
        {
            string userInputStr;
            userInputStr = Console.ReadLine();
            while (!isValidInput(userInputStr))
            {
                userInputStr = Console.ReadLine();
            }

            return userInputStr;
        }

        private static int findMinimumDigit(string i_UserInputStr)
        {
            int minimumDigit = 0;
            for (int i = 0; i < k_LengthString; i++)
            {
                if (minimumDigit > i_UserInputStr[i])
                {
                    minimumDigit = i_UserInputStr[i];
                }
            }

            return minimumDigit;
        }

        private static int findMaximumDigit(string i_UserInputStr)
        {
            int MaximumDigit = 0;
            for (int i = 0; i < k_LengthString; i++)
            {
                if (MaximumDigit > i_UserInputStr[i])
                {
                    MaximumDigit = i_UserInputStr[i];
                }
            }

            return MaximumDigit;
        }

        private static int howManyDigitCanBeDivideBy3(string i_UserInputStr)
        {

        }


        private static bool isValidInput(string i_UserInputStr)
        {
            bool isUserValidInput = true;

            if (i_UserInputStr.Length != k_LengthString)
            {
                isUserValidInput = false;
            }

            else
            {
                for (int i = 0; i < k_LengthString; i++)
                {
                    if (!char.IsDigit(i_UserInputStr[i]))
                    {
                        isUserValidInput = false;
                        break;
                    }
                }
            }

            return isUserValidInput;

        }

        private static int convertBinaryNumberToDecimal(string i_UserInput)
        {
            int pow = 0;
            double decimalNumber = 0;
            int number = 0;

            int.TryParse(i_UserInput, out int binaryNumber);

            while (binaryNumber > 0)
            {
                decimalNumber += (binaryNumber % 10) * Math.Pow(2, pow);
                pow++;
                binaryNumber = binaryNumber / 10;
            }

            return (int)decimalNumber;
        }
    }
