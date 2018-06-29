using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string [] input = new string[] { "a", "b", "c", "d"};

            //string[] output = Test(input);
            //Console.WriteLine(input[0]);
            //Print(input);
            //Console.WriteLine();
            //Print(output);

            ArrayReverse();
            Console.Read();
        }

        static string[] Test(string[] myArray)
        {          
           string [] reverseArray = new string[myArray.Length];
           int i = 0; 
           for (var e = myArray.Length - 1; e >= 0; e--)
           {
              reverseArray[i] = myArray[e];
              i++;
           }
            return reverseArray;
        }

        static void Print(string [] arr)
        {
            int index = 0;
            foreach(string item in arr)
            {
                Console.Write($"{item}");
                if(index != arr.Length)
                {
                    Console.Write(",");
                }
                index++;
            }
        }

        public static void ArrayReverse()
        {
            int[] givenArr = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            int[] ReverseArray = new int[givenArr.Length];

            for (var i = givenArr.Length - 1; i >= 0; i--)
            {
                ReverseArray[i] = givenArr[i];
                Console.WriteLine(ReverseArray[i]);
            }
            Console.WriteLine();
        }

    }
}
