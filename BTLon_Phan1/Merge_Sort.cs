//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTLon_Phan1
//{
//    class Merge_Sort
//    {
//        public static void mergeSort(int[] arr)
//        {
//            if (arr.Length > 1)
//            {
//                int mid = arr.Length / 2;
//                int[] left = new int[mid];
//                int[] right = new int[arr.Length - mid];

//                for (int i = 0; i < mid; ++i)
//                    left[i] = arr[i];
//                for (int i = mid; i < arr.Length; ++i)
//                    right[i - mid] = arr[i];

//                mergeSort(left);
//                mergeSort(right);

//                Merge(arr, left, right);
//            }
//        }

//        private static void Merge(int[] arr, int[] left, int[] right)
//        {
//            int i = 0, j = 0, k = 0;

//            while (i < left.Length && j < right.Length)
//            {
//                if (left[i] <= right[j])
//                    arr[k++] = left[i++];
//                else
//                    arr[k++] = right[j++];
//            }

//            while (i < left.Length)
//                arr[k++] = left[i++];

//            while (j < right.Length)
//                arr[k++] = right[j++];
//        }

//        static void Main(String[] args)
//        {
//            int[] numbers = { 5, 2, 4, 6, 1, 3, 2, 6 };
//            Console.Write("Mang truoc khi sap xep: ");
//            foreach (int num in numbers)
//                Console.Write(num + " ");

//            mergeSort(numbers);

//            Console.Write("\nMang sau khi sap xep: ");
//            foreach (int num in numbers)
//                Console.Write(num + " ");

//            Console.ReadLine();
//        }
//    }
//}
