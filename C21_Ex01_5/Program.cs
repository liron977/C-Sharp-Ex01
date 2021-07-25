using System;

namespace C21_Ex01_5
{
    class Program
    {
        public const int k_NumberOfDigit = 9;

        public static void Main()
        {
            printNumberStatistics();
        }

        private static void printNumberStatistics()
        {
            string userInput = getUserInput();
            int maxDigit = findMaximumDigit(userInput);
            int minDigit = findMinimumDigit(userInput);
            int countDividedBy3Digit = findCountDigitDividedBy3(userInput);
            int countDigitsBiggerFromFirstDigit = findCountDigitsBiggerFromUnityDigit(userInput);
            string messageToTheUserAboutTheNumbers = String.Format(
                $@"-The maximum digit is {maxDigit}.
-The minimum digit is {minDigit}.
-The count of digits that can be divided by 3: {countDividedBy3Digit}. 
-There are {countDigitsBiggerFromFirstDigit} digits which are bigger than the unity digit.");

            Console.WriteLine(messageToTheUserAboutTheNumbers);
        }

        private static string getUserInput()
        {
            Console.WriteLine("Please enter a positive number with 9 digits");
            string userInputStr = Console.ReadLine();

            while(!isValidInput(userInputStr))
            {
                Console.WriteLine("Invalid input,please enter a positive number with 9 digits");
                userInputStr = Console.ReadLine();
            }

            return userInputStr;
        }

        private static int findMinimumDigit(string i_UserInputStr)
        {
            double minimumDigit = char.GetNumericValue(i_UserInputStr[0]);

            for(int i = 0; i < k_NumberOfDigit; i++)
            {
                minimumDigit = Math.Min(char.GetNumericValue(i_UserInputStr[i]), minimumDigit);
            }

            return (int)minimumDigit;
        }

        private static int findMaximumDigit(string i_UserInputStr)
        {
            double maximumDigit = 0;

            for(int i = 0; i < k_NumberOfDigit; i++)
            {
                maximumDigit = Math.Max(char.GetNumericValue(i_UserInputStr[i]), maximumDigit);
            }

            return (int)maximumDigit;
        }

        private static int findCountDigitDividedBy3(string i_UserInputStr)
        {
            int countDividedBy3Digit = 0;

            for(int i = 0; i < k_NumberOfDigit; i++)
            {
                if(char.GetNumericValue(i_UserInputStr[i]) % 3 == 0)
                {
                    countDividedBy3Digit++;
                }
            }

            return countDividedBy3Digit;
        }

        private static bool isValidInput(string i_UserInputStr)
        {
            bool isUserValidInput = true;
            int countOfZero = 0;

            if(i_UserInputStr.Length != k_NumberOfDigit)
                isUserValidInput = false;

            else
                for(var i = 0; i < k_NumberOfDigit; i++)
                {
                    if(!char.IsDigit(i_UserInputStr[i]))
                    {
                        isUserValidInput = false;
                        break;
                    }
                    else if(i_UserInputStr[i] == '0')
                    {
                        countOfZero++;
                    }
                }

            if(countOfZero == k_NumberOfDigit)
            {
                isUserValidInput = false;
            }

            return isUserValidInput;
        }

        private static int findCountDigitsBiggerFromUnityDigit(string i_UserInput)
        {
            int countDigitsBiggerFromFirstDigit = 0;
            int unityDigit = (int)char.GetNumericValue(i_UserInput[k_NumberOfDigit-1]);
            int currentDigit = unityDigit;

            for(int i = 0; i < k_NumberOfDigit-1; i++)
            {
                currentDigit = (int)char.GetNumericValue(i_UserInput[i]);
                if(currentDigit > unityDigit)
                {
                    countDigitsBiggerFromFirstDigit++;
                }
            }

            return countDigitsBiggerFromFirstDigit;
        }
    }
}