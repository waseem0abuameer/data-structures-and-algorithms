using System;

namespace ConsoleApp4
{
    public class Program
    {
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {

                int Position = partition(arr, left, right);

                // Separately sort elements before
                // partition and after partition
                QuickSort(arr, left, Position - 1);
                QuickSort(arr, Position + 1, right);
            }
            return arr;

        }

        public static int partition(int[] arr, int left, int right)
        {
            int pivot = arr[right]; 
            int low = left - 1; 

            for (int j = left; j < right ; j++)
            {
                // If current element is smaller than the pivot
                if (arr[j] <= pivot)
                {
                    low++; // increment index of smaller element
                    swap(arr, j, low);

                }
            }
            swap(arr, right, low + 1);
            return (low + 1);
        }

        public static void swap(int[] arr, int v1, int v2)
        {
            int t = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = t;
        }
        public  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int[] arr1 = QuickSort(arr, 0, arr.Length - 1);
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr1[i]);

        }

       
    }
}
