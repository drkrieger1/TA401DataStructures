using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class BinarySearcher
    {
        //Binary Search
        public int BinarySearch(int[] arr, int search)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = end / 2;

            while( arr[mid] != search)
            {
                if(mid == start || mid == end)
                {   
                    //Search value does not exist in the array
                    return -1;
                }

                //Search Left
                if(arr[mid] > search)
                {
                    end = mid - 1;
                    mid = end / 2;
                }

                //Search Right
                if(arr[mid] < search)
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                }
            }

            return mid;
        }
    }
}
