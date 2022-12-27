using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
                Console.WriteLine(ReverseCase("Happy Birthday"));
        }


        public static string ReverseCase(string str)
        {
            return String.Concat(str.Select(letter => char.IsUpper(letter) ? char.ToLower(letter) : char.ToUpper(letter)));

        }

        #region performed
        
        public static string HackerSpeak(string str)
        {
            return str.Replace("a", "4").Replace("e", "3").Replace("i", "1")
                .Replace("o", "0").Replace("s", "5");
        }
        public static int[] SortNumsAscending(int[] arr)
        {
            return arr.OrderBy(element => element).ToArray();
        }
        private static int GetAbsSum(int[] arr)
        {
 
            return arr.Select(Math.Abs).Sum();
        } 
        
        
        public static int[] MultiplyByLength(int[] arr)
        {
            return arr.Select(num => num * arr.Length).ToArray();
        }
        public static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }

        public static string NameShuffle(string str)
        {
            
            return string.Join(" ", str.Split(' ').Reverse());
        }

        public static string smallerNum(string n1, string n2)
        {
            // int num1 = Int32.Parse(n1);
            //int num2 = Int32.Parse(n2);

            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);

            if (num1 < num2) return num1.ToString(); else return num2.ToString();

        }



        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] filled = new int[length];
            for (int i = 0; i < length; i++)
            {
                filled[i] = num * (i + 1);
            }
            return filled;
        }

        #endregion

    }
}