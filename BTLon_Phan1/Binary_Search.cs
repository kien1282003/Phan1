using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_Phan1
{
    class Binary_Search
    {
        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
            Console.WriteLine("Mang la:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            int index = BinarySearch(numbers, 7);
            Console.WriteLine("\nPhan tu 7 xuat hien o vi tri so " + index);
            Console.ReadLine();
        }
    }
}
