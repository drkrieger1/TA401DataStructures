using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");
            int[] nums = { 2, 1, 20, 8, 1 };
            int[] nums2 = { 2, 1, 20, 8, 4, 3, 10 };

            Print(nums);
            BubbleSort(nums);
            Console.WriteLine();
            //Print(nums2);
            //BubbleSort(nums2);

            Console.WriteLine();
            Console.WriteLine("Bubble Sort with just a while");
            Print(nums2);
            Bubble(nums2);
            Console.Read();
        }
       
        /////Print Method/////
        public static void Print(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
        }
        
        //Bubble Sort using a Do-While
        public static void BubbleSort(int[] arr)
        {
            bool swap;

            do
            {
                swap = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swap = true;
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            } while (swap == true);

            Console.WriteLine();
            Print(arr);
        }

        //Bubble Sort with just one While Loop
        public static void Bubble(int[] arr)
        {
            bool end = false;
            int index = 0;
            while(end is false)
            {
                if(arr[index] < arr[index + 1])
                {
                    index++;
                }
                if (index == arr.Length -1)
                {
                    end = true;
                }

                if(index != arr.Length - 1)
                {
                    if(arr[index] > arr[index + 1])
                    {
                        int temp = arr[index + 1];
                        arr[index + 1] = arr[index];
                        arr[index] = temp;
                    }
                }
            }
            Console.WriteLine();
            Print(arr);
        }
    }
}
