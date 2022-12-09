﻿namespace CollectionsPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Three Basic Arrays\n");

            //Create an array to hold integer values 0 through 9
            int[] numbersArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] namesArr = { "Tim", "Martin", "Nikki", "Sara" };

            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArr = new bool[10];
            for (int i = 0; i < boolArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolArr[i] = true;
                } else
                {
                    boolArr[i] = false;
                }
            }

            Console.WriteLine("A print out with values 0 - 9:\n");
            PrintAllItems(numbersArr);

            Console.WriteLine("\nItems in Names Array:");
            foreach(var name in namesArr)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nBoolean Array:");
            foreach (var val in boolArr) {
                Console.WriteLine(val);
            }
        }

        static void PrintAllItems(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}