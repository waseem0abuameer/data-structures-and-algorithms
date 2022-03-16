using System;

namespace array_insert_shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            int y=0;    
            y= int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            int []arr=new int[x];
            for (int i=0; i<arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
           Console.WriteLine(arr[arr.Length/2]);
        }
    }
}
