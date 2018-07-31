using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort");

            int[] test = { 51, 95, 66, 72, 42, 38, 41, 15 };
            QuickSort(test);

            Console.Read();
        }

        public static int[] QuickSort(int[] arr)
        {
            int pivot = 0;
            int front = 1;
            int end = arr.Length - 1;

            while(front < end)
            {
                //check front against the pivot value
                if(arr[pivot] < arr[front])
                {
                    int temp = arr[end];
                    arr[end] = arr[front];
                    arr[front] = temp;
                    front++;
                    end--;
                }
                //check Rear against the pivot value
            }

            if(arr[end] < arr[pivot])
            {
                int temp = arr[pivot];
                arr[pivot] = arr[end];
                arr[end] = temp;
                pivot = end;
            }
            //sort left 
            arr = SubSort(arr, pivot, pivot - 1);

            //Sort Right
            arr = SubSort(arr, pivot, arr.Length - 1);

            Console.Read();

            return arr;
        }

        public static int[] SubSort(int[] arr, int pivot, int end)
        {

            return arr;
        }
    }
}
