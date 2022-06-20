using System;
using Xunit;
using HashTable;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestOne()
        {
            string s1 = "to negotiate contract labor for the Kingdom of Hawaii's sugar plantations, with hopes of saving the dwindling";

            Assert.Equal("of", Program.RepeatedWord(s1));
        }

        [Fact]
        public void TestTwo()
        {
            string s2 = " that the acquisition of land for the Utah resort hotel Amangiri (pictured) required an act of Congress?";

            Assert.Equal("the", Program.RepeatedWord(s2));
        }

        [Fact]
        public void TestThree()
        {
            string s3 = "commemorated a century later a with ";

            Assert.NotEqual("b", Program.RepeatedWord(s3));
        }

        [Fact]
        public void testcode301()
        {
            HashTable.HashTable testHashtable = new HashTable.HashTable();

            testHashtable.Set("100", "Ali");

            Assert.True(testHashtable.Contains("100"));
        }

        [Fact]
        public void testcode302()
        {
            HashTable.HashTable testHashtable = new HashTable.HashTable();

            testHashtable.Set("1", "waseem");

            Assert.Equal("waseem", testHashtable.Get("1").Value);
        }
          
    

        [Fact]
        public void TestLeftJoin()
        {
            HashTable.HashTable left = new HashTable.HashTable();
            left.Set("1", "10");
            left.Set("2", "10");

            HashTable.HashTable right = new HashTable.HashTable();
            right.Set("5", "50");
            right.Set("6", "50");


            List<string> thenew = new List<string>();
            thenew.Add("1, 10, NULL");
            thenew.Add("2, 10, NULL");

            List<string> theold = Program.LeftJoin(left, right);

            Assert.Equal(thenew, theold);
        }

    }
}
