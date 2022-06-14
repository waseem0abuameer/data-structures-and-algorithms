using System;
using Xunit;
using HashTable;
using HashTable;
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

     
     

    }
}
