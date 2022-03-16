using System;

namespace Class_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter the numbers of elements");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [n];
            fillArray(arr, n);
            OutArray(arr);
            //call function to make reverse
            reverseArray(arr);
            OutArray(arr);
        }



        static void reverseArray(int[] arr)
        {
            //loop in array elements
            for (int i = 0; i < arr.Length / 2; i++)
            {
                //make the var to make swap without lose the value
                int tmp = arr[i];
                //make swap
                arr[i] = arr[arr.Length - i - 1];
                //put the value in this var to don't lose the value
                arr[arr.Length - i - 1] = tmp;
            }
           
        }
        static void fillArray(int[] arr,int n)
        {
            //loop in array elements
            for (int i = 0; i < n ; i++)
            {
             arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        static void OutArray(int[] arr)
        {
            //loop in array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"  ");
                 
            }

        }
    }
}
