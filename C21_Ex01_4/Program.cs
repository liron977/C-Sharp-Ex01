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
            stringAnalysis();
        }

        private static void stringAnalysis()
        {
            string userInput = getUserInput();
            bool stringIsPalindrome=false;
            checkIfStringIsPalindrome(ref stringIsPalindrome, userInput, 0, 7);
   
            string messageToTheUser =
                String.Format($@"-The number {str} be divide by 5 ");
            Console.WriteLine(messageToTheUser);

            if (char.IsLetter(userInput[0]))
            {
                printCountOfuppercaseLetter(userInput);
            }
            else
            {
                int.TryParse(userInput, out int decimalNumber);
                PrintIfNumberDivideBy5(decimalNumber);
            }
        }

        private static void checkIfStringIsPalindrome(ref bool stringIsPalindrome, string i_UserInput, int leftStringIndex,int rightStringIndex)
        {

            if (leftStringIndex >= rightStringIndex)
            {
                stringIsPalindrome = true;

            }

            else if (i_UserInput[leftStringIndex] == i_UserInput[rightStringIndex])
            {
                checkIfStringIsPalindrome(ref stringIsPalindrome,i_UserInput, leftStringIndex + 1, rightStringIndex - 1);
            }
            else
            {
                stringIsPalindrome = false;
                return;
            }

        }

        private static void PrintIfNumberDivideBy5(int i_number)
        {
            bool isDivideBy5 = false;
            string str = "can";
            isDivideBy5 = i_number % 5 == 0;
            if (!isDivideBy5)
            {
                str = "can not";
            }
            string messageToTheUser =
                String.Format($@"-The number {str} be divide by 5 ");
            Console.WriteLine(messageToTheUser);
        }

        private static void printCountOfuppercaseLetter(string i_userInput)
        {
            int counterOfUppercaseLetters = 0;
            for (int i = 0; i < i_userInput.Length; i++)
            {
                if (char.IsUpper(i_userInput[i]))
                {
                    counterOfUppercaseLetters++;
                }
            }

            string messageToTheUser =
                String.Format($@"-The number of uppercase letters is {counterOfUppercaseLetters}");
            Console.WriteLine(messageToTheUser);
        }
        private static string getUserInput()
        {
            bool isValidInput = false;
            string userInput = string.Empty;
            while (!isValidInput)
            {
                Console.WriteLine("Please enter a string:");
                userInput = Console.ReadLine();
                isValidInput = isValidString(userInput);
                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input,please enter a constant string with 8 chars ");
                }
            }
            Console.Write(Environment.NewLine);
            return userInput;
        }

        private static bool isValidString(string i_UserInput)
        {
            bool isValidInput = false;
            char firstInputChar = i_UserInput[0];
            bool isFirstCharIsDigit = char.IsDigit((firstInputChar));
            bool isFirstCharIsLetter = char.IsLetter((firstInputChar));
            if ((i_UserInput.Length == 8)&&(char.IsLetterOrDigit(firstInputChar)))
            {
                for (int i = 0; i < i_UserInput.Length; i++)
                {
                    isValidInput = ((isFirstCharIsLetter && char.IsLetter(i_UserInput[i])) ||
                                   (isFirstCharIsDigit && char.IsDigit(i_UserInput[i])));
                    if (!isValidInput)
                    {
                        break;
                    }
                }
            }

            return isValidInput;
        }

    }

}
