using System;

namespace InsortionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Sort");

            int[] nums = {2, 4, 10, 3, 5, 1, 8};
            Print(nums);
            InsertSort(nums);

            Console.Read();
        }

        public static void InsertSort(int[] arr)
        {
            int newNum;
            for(int i = 1; i < arr.Length; i++)
            {
                //We start a position 1 instead of 0
                newNum = arr[i];
                //Set j to i for the while loop
                int j = i;
            
                while(j > 0 && arr[j - 1] > newNum)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = newNum;
            }

            Print(arr);
        }

        public static void Print(int[] arr)
        {
            Console.WriteLine();

            foreach(int n in arr)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
