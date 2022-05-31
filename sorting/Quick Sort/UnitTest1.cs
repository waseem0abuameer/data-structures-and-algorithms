using System;
using Xunit;
using ConsoleApp4;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = { 20, 18, 12, 8, 5, -2 };
            int[] arr1 =Program.QuickSort(arr, 0, arr.Length - 1);
            Assert.Equal(arr1, arr);
        }
        [Fact]
        public void Test2()
        {
            int[] arr = { 5, 12, 7, 5, 5, 7 };
            int[] arr1 = Program.QuickSort(arr, 0, arr.Length - 1);
            Assert.Equal(arr1, arr);
        }
        [Fact]
        public void Test3()
        {
            int[] arr = { 2, 3, 5, 7, 13, 11 };
            int[] arr1 = Program.QuickSort(arr, 0, arr.Length - 1);
            
            Assert.Equal(arr1, arr);
        }
    }
}
