using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort");

            int[] test = { 51, 95, 66, 72, 42, 38, 41, 15 };

            int[] test2 = { 15, 3, 2, 35, 40, 25 };
            Console.WriteLine("Array In: ");
            Print(test);
            Console.WriteLine();

            int [] result = QuickSort(test, 0, test.Length - 1);
            Console.WriteLine("Array Sorted: ");
            Print(result);


            Console.Read();
        }
        //quickSort method
        //Input: unsorted array, Left index, Right index
        public static int[] QuickSort(int[] arr, int left, int right)
        {   
            //Base case: breaks recursion if the left index
            //passes or reaches the right index
            if(left >= right)
            {
                return arr;
            }
            
            //Picking a middle pivot
            int pivot = arr[(left + right) / 2];

            //partision
            int index = Partision(arr, left, right, pivot);
            //call partision on the left and right
            QuickSort(arr, left, index - 1);
            QuickSort(arr, index, right);
            return arr;
        }

        public static int Partision(int[] arr, int left, int right, int pivot)
        {   
            //Loop till left reaches right
            while(left <= right)
            {   
                //find the number that on the left that is less than the pivot
                while(arr[left] < pivot)
                {
                    left++;
                }
                //find the number that is greater than the pivot
                while(arr[right] > pivot)
                {
                    right--;
                }
                //Swap left and right
                if(left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            //return left the, it splits the array. 
            return left;
        }

        public static void  Print(int[] arr)
        {
            foreach(int n in arr)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
