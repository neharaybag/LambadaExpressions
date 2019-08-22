using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class LambadaExamples
    {
        

        static void Main(string[] args)
        {
            int calculateSquare(int num) => num * num;

            int result = calculateSquare(25);

            Console.WriteLine($"Result is {result}");

           
            // Calculate square of all numbers in list and store it to other list
            List<int> numbers = new List<int> { 2, 3, 6, 7, 8, 9, 10 ,15,19,45,33};

            var squares = numbers.ConvertAll(val => val * val);

            PrintList(squares);

            // Find all odd numbers

            Console.WriteLine("All odd numbers");

            PrintList(numbers.FindAll(x => x % 2 != 0));


            List<String> words = new List<String> { "is", "cake", "icecream", "coke", "ball", "bread" };

            // This is predicate           

            bool predicate(string s) => s.StartsWith("c");

            words.RemoveAll(s => predicate(s));

            // List of string after removing string starting with c

            Console.WriteLine("List after removing words starting with c");

            PrintList(words);       

            Console.ReadLine();
        }


        public static void PrintList <T> (List<T>list)
        {
            foreach(var val in list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
