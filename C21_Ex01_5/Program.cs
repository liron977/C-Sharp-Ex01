using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex01_5
{
    class Program
    {
        public const int k_NumberOfDigit = 9;

        static void Main()
        {
            printNumberStatistics();
        }

        private static void printNumberStatistics()
        {
            string userInput = getUserInput();
            int maxDigit = findMaximumDigit(userInput);
            int minDigit = findMinimumDigit(userInput);
            int countDividedBy3Digit = FindCountDigitDividedBy3(userInput);
            int countDigitsBiggerFromFirstDigit=FindCountDigitsBiggerFromFirstDigit(userInput);
            string messageToTheUserAboutTheNumbers = String.Format($@"-The maximum digit is {maxDigit}.
-The minimum digit is {minDigit}.
-The count of digits that can be divided by 3: {countDividedBy3Digit}. 
-There are {countDigitsBiggerFromFirstDigit} digits which are bigger then the first digit.");
           
            Console.WriteLine(messageToTheUserAboutTheNumbers);

        }

        private static string getUserInput()
        {
            Console.WriteLine("Please enter a positive number with 9 digits");
            string userInputStr=String.Empty;

            userInputStr = Console.ReadLine();
            while (!isValidInput(userInputStr))
            {
                Console.WriteLine("Invalid input,please enter a positive number with 9 digits");
                userInputStr = Console.ReadLine();
              
            }

            return userInputStr;
        }

        private static int findMinimumDigit(string i_UserInputStr)
        {
            double minimumDigit = char.GetNumericValue(i_UserInputStr[0]);

            for (int i = 0; i < k_NumberOfDigit; i++)
            {
               
                    minimumDigit =Math.Min(char.GetNumericValue(i_UserInputStr[i]), minimumDigit);
            }

            return (int)minimumDigit;
        }

        private static int findMaximumDigit(string i_UserInputStr)
        {
            double MaximumDigit =0;
            for (int i = 0; i < k_NumberOfDigit; i++)
            {
                MaximumDigit = Math.Max(char.GetNumericValue(i_UserInputStr[i]), MaximumDigit);
            }

            return (int)MaximumDigit;
        }

        private static int FindCountDigitDividedBy3(string i_UserInputStr)
        {
            int countDividedBy3Digit = 0;
            for (int i = 0; i < k_NumberOfDigit; i++)
            {
                if (char.GetNumericValue(i_UserInputStr[i]) % 3 == 0)
                {
                    countDividedBy3Digit++;
                }
            }

            return countDividedBy3Digit;

        }

        private static bool isValidInput(string i_UserInputStr)
        {
            bool isUserValidInput = true;

            if (i_UserInputStr.Length != k_NumberOfDigit)
            {
                isUserValidInput = false;
            }

            else
            {
                for (int i = 0; i < k_NumberOfDigit; i++)
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

        private static int FindCountDigitsBiggerFromFirstDigit(string i_UserInput)
        {
            int countDigitsBiggerFromFirstDigit = 0;
            int firstDigit = (int)char.GetNumericValue(i_UserInput[0]);
            int currDigit = 0;
            for (int i = 1; i < k_NumberOfDigit; i++)
            {
                currDigit = (int) char.GetNumericValue(i_UserInput[i]);
                if (currDigit > firstDigit)
                {
                    countDigitsBiggerFromFirstDigit++;
                }
            }

            return countDigitsBiggerFromFirstDigit;
        }

    }
}

