using System;


namespace C21_Ex01_4
{
    class Program
    {
        public static void Main()
        {
            stringAnalysis();
        }

        private static void stringAnalysis()
        {
            bool stringIsPalindrome = false;
            string str = "";
            string userInput = getUserInput();

            checkIfStringIsPalindrome(ref stringIsPalindrome, userInput, 0, 7);
            if(!stringIsPalindrome)
            {
                str = " not";
            }

            string messageToTheUser = String.Format($@"-The string is{str} palindrome ");
            Console.WriteLine(messageToTheUser);
            if(char.IsLetter(userInput[0]))
            {
                printCountOfUppercaseLetter(userInput);
            }
            else
            {
                int.TryParse(userInput, out int decimalNumber);
                printIfNumberDivideBy4(decimalNumber);
            }
        }

        private static void checkIfStringIsPalindrome(
            ref bool io_StringIsPalindrome,
            string i_UserInput,
            int i_LeftStringIndex,
            int i_RightStringIndex)
        {
            if(i_LeftStringIndex >= i_RightStringIndex)
            {
                io_StringIsPalindrome = true;
            }

            else if(i_UserInput[i_LeftStringIndex] == i_UserInput[i_RightStringIndex])
            {
                checkIfStringIsPalindrome(
                    ref io_StringIsPalindrome,
                    i_UserInput,
                    i_LeftStringIndex + 1,
                    i_RightStringIndex - 1);
            }
            else
            {
                io_StringIsPalindrome = false;
            }
        }

        private static void printIfNumberDivideBy4(int i_Number)
        {
            bool isDivideBy4 = i_Number % 4== 0;
            string str = "can";

            if(!isDivideBy4)
            {
                str = "can not";
            }

            string messageToTheUser = String.Format($@"-The number {str} be divide by 4 ");
            Console.WriteLine(messageToTheUser);
        }

        private static void printCountOfUppercaseLetter(string i_UserInput)
        {
            int counterOfUppercaseLetters = 0;

            for(int i = 0; i < i_UserInput.Length; i++)
            {
                if(char.IsUpper(i_UserInput[i]))
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

            while(!isValidInput)
            {
                Console.WriteLine("Please enter a string:");
                userInput = Console.ReadLine();
                isValidInput = isValidString(userInput);
                if(!isValidInput)
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

            if((i_UserInput.Length == 8) && (char.IsLetterOrDigit(firstInputChar)))
            {
                for(int i = 0; i < i_UserInput.Length; i++)
                {
                    isValidInput = ((isFirstCharIsLetter && char.IsLetter(i_UserInput[i]))
                                    || (isFirstCharIsDigit && char.IsDigit(i_UserInput[i])));
                    if(!isValidInput)
                    {
                        break;
                    }
                }
            }

            return isValidInput;
        }
    }
}