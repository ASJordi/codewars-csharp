using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class phoneNumber
    {
        /// <summary>
        /// Write a function that accepts an array of 10 integers (between 0 and 9), 
        /// that returns a string of those numbers in the form of a phone number.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>

        public static string CreatePhoneNumber(int[] numbers)
        {
            // Create array with format phone number 
            string[] numbersList = { "(", "X", "X", "X", ")", " ", "X", "X", "X", "-", "X", "X", "X", "X" };

            // Add elements from array to numbersList and define format of phone number

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                    numbersList[1] = numbers[i].ToString();
                if (i == 1)
                    numbersList[2] = numbers[i].ToString();
                if (i == 2)
                    numbersList[3] = numbers[i].ToString();

                if (i == 3)
                    numbersList[6] = numbers[i].ToString();
                if (i == 4)
                    numbersList[7] = numbers[i].ToString();
                if (i == 5)
                    numbersList[8] = numbers[i].ToString();

                if (i == 6)
                    numbersList[10] = numbers[i].ToString();
                if (i == 7)
                    numbersList[11] = numbers[i].ToString();
                if (i == 8)
                    numbersList[12] = numbers[i].ToString();
                if (i == 9)
                    numbersList[13] = numbers[i].ToString();
            }

            // Convert List to String
            string phoneNumber = string.Join("", numbersList);

            return phoneNumber;

            //Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
        }
    }
}
