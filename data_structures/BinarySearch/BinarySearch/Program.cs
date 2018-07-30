using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearch");

            BinarySearcher search = new BinarySearcher();

            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int find = -1 ;
            int result = search.BinarySearch(test, find);

            if(result == -1)
            {
                Console.WriteLine($"{find} is not in the array");
            }
            else
            {
                Console.WriteLine($"index of:{find} is {result}");
            }
            Console.Read();
        }
    }
}
