using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return $"Hello {name}!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int Age)
        {
            if (Age >= 18)
            {
                return true;
            } else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string FullName)
        {
            string FirstName = FullName.Substring(0, FullName.IndexOf(" "));
            return FirstName;
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string str)
        {
            string NewStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                NewStr += str[i];
            }
            return NewStr;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.

        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int integer)
        {
            string final = "";
            for (int i = 1; i < 10; i++)
            {
                int result = integer * i;
                final += $"{integer} * {i} = {result}\r\n";
            }
            final += $"{integer} * 10 = {integer * 10}";
            return final;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            double fahrenheit = Math.Round(kelvin * (9.0 / 5.0) - 459.67, 2);
            return fahrenheit;
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] array)
        {
            double sum = 0.00;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] array)
        {
            return array.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
            string pyramidLine = "";
            int holdWidth = width;
            for (int i = holdWidth; i > 1; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    pyramidLine += number;
                }
                pyramidLine += "\r\n";
                width--;
            }
            pyramidLine += number;
            return pyramidLine;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            double minutesInHours = minutes / 60.0;
            double secondsInHours = seconds / 3600.0;
            double totalTimeInHours = hours + minutesInHours + secondsInHours;
            double mph = Math.Round(distance / totalTimeInHours, 0);
            string milesph = mph.ToString() + "MPH";
            return milesph;
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char c)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char c)
        {
            if (!("aeiouAEIOU".IndexOf(c) >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937.
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int n)
        {
            int count = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    count += 1;
                }
                else
                {
                    n = n * 3 + 1;
                    count += 1;
                }
            }
            return count;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime date)
        {
            DateTime[] next7Days = new DateTime[7];
            for (int i = 0; i < 7; i++)
            {
                next7Days[i] = date;
                date = date.AddDays(1);
            }
            return next7Days;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int date)
        {
            if(date % 4 == 0 && (date % 400 == 0 || date % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(decimal loanBalance, double iRate, int loanTerm, int paymentPeriod)
        {
            double payments = 0;
            if (paymentPeriod == 12)
            {
                payments = loanTerm * 12;
            }
            else
            {
                payments = loanTerm * 6;
            }
            double lBalance = decimal.ToDouble(loanBalance);
            double monthlyPayment = ((iRate/1200) + (iRate/1200) / (Math.Pow(1 + (iRate/1200), payments) - 1)) * lBalance;
            return Math.Round(monthlyPayment, 2);
            
        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         *
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
         public static string DuckGoose(int z)
        {
            string result = "";
            for (int i = 1; i <= z; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                {
                    result += "DuckGoose";
                }
                else if(i % 3 == 0)
                {
                    result += "Duck";
                }
                else if(i % 5 == 0)
                {
                    result += "Goose";
                }
                else
                {
                    result += $"{i}";
                }
                if(i < z)
                {
                    result += Environment.NewLine;
                }
            }
            return result;
        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}