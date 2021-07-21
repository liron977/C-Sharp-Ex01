using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex01_01
{
   public class Program
   {
       public const int k_InputSeriesLength = 3;
       public const int k_BinaryInputLength = 9;
        private static string[] m_InputNumbersArray=new string[k_InputSeriesLength];
  
        private static void Main()
        {
            binarySeries();
        }
        private static void binarySeries()
        {
            string userInput;

            Console.WriteLine("Please enter 3 binary numbers including 9 digits:");
            for (int i = 0; i < k_InputSeriesLength; i++)
            { 
                userInput = Console.ReadLine();
                if (!isValidUserInput(userInput))
                {
                    Console.WriteLine("Invalid input,please enter a binary number");
                    i--;
                }
                else
                {
                    m_InputNumbersArray[i] = userInput;
                }

            }

            printBinarySeriesStatistics();
        }

        private static void printBinarySeriesStatistics()
        {

           int minimumNumber = Int32.MaxValue;
           int maximumNumber = 0;
            int sumOfZerosInTheBinarySeries = 0;
            int sumOfOnesInTheBinarySeries = 0;
            int decimalNumber = 0;
            int countOfNumbersPowerOfTwo = 0;
            int countOfAscendingNumbers = 0;
            double averageOfZeroInBinaryNumber = 0;
            double averageOfOnesInBinaryNumber = 0;

            StringBuilder finalMessage = new StringBuilder("-The decimal numbers are:  ");
            for (int i = 0; i < k_InputSeriesLength; i++)
            {

                decimalNumber = convertBinaryNumberToDecimal(m_InputNumbersArray[i]);
                finalMessage.AppendFormat("{0} ", decimalNumber);
                countZerosAndOnesInBinaryNumber(m_InputNumbersArray[i], ref sumOfOnesInTheBinarySeries, ref sumOfZerosInTheBinarySeries);
                if (isPowerOfTwo(decimalNumber))
                {
                    countOfNumbersPowerOfTwo++;
                }

                if (isAscendingNumber(decimalNumber))
                {
                    countOfAscendingNumbers++;
                }

                if (decimalNumber > maximumNumber)
                {
                    maximumNumber = decimalNumber;
                }

                if (decimalNumber < minimumNumber)
                {
                    minimumNumber = decimalNumber;
                }
            }

            averageOfOnesInBinaryNumber = sumOfOnesInTheBinarySeries / k_InputSeriesLength;
            averageOfZeroInBinaryNumber= sumOfZerosInTheBinarySeries / k_InputSeriesLength;
            string messageToTheUserAboutTheNumbers = String.Format($@"-The general average of zeros is {averageOfZeroInBinaryNumber}.
-The general average of ones is {averageOfOnesInBinaryNumber}.
-The count of numbers that are the power of two: {countOfNumbersPowerOfTwo}. 
-There are {countOfAscendingNumbers} numbers which are an ascending series.
-The minimum number is {minimumNumber}.
-The maximum number is {maximumNumber}.");

            finalMessage.AppendFormat("{0} ", '.');
            Console.WriteLine(finalMessage);
            Console.WriteLine(messageToTheUserAboutTheNumbers);

        }

        private static bool isAscendingNumber(int decimalNumber)
        {
            int prevDigit = Int32.MaxValue;
            int currDigit = 0;
            bool isNumberAscending = true;

            while (decimalNumber>0)
            {
                currDigit = decimalNumber % 10;
                if (prevDigit <= currDigit)
                {
                    isNumberAscending = false;
                    break;
                }

                prevDigit = currDigit;
                decimalNumber = decimalNumber / 10;
            }

            return isNumberAscending;

        }

        private static bool isPowerOfTwo(int decimalNumber)
        {
            bool isPowerOfTwo = false;
            isPowerOfTwo = (decimalNumber & (decimalNumber - 1)) == 0 && decimalNumber != 0;
            return isPowerOfTwo;

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
        private static void countZerosAndOnesInBinaryNumber(string i_UserInput, ref int sumOfOnesInTheBinarySeries, ref int sumOfZerosInTheBinarySeries)
        {
            for (int i = 0; i < k_BinaryInputLength; i++)
            {
                if (i_UserInput[i] == '0')
                {
                    sumOfZerosInTheBinarySeries++;
                }
                else
                {
                    sumOfOnesInTheBinarySeries++;
                }
            }

        }

        private static bool isValidUserInput(string i_UserInput)
        {
            bool isValidInput = isValidInputLength(i_UserInput) && isValidBinaryInput(i_UserInput);

            return isValidInput;
        }

        private static bool isValidInputLength(string i_UserInput)
        {
            bool isValidInputLength;
            int userInputLength = i_UserInput.Length;

            isValidInputLength = userInputLength == k_BinaryInputLength;

            return isValidInputLength;
        }

        private static bool isValidBinaryInput(string i_UserInput)
        {
            bool isValidBinaryInput = true;

            for (int i = 0; i < k_BinaryInputLength && isValidBinaryInput; i++)
            {
                isValidBinaryInput = i_UserInput[i] == '0' || i_UserInput[i] == '1';
            }

            return isValidBinaryInput;
        }

    }
}
