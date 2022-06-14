using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            //HashTable HashTable1 = new HashTable();

            //HashTable1.Set("1", "waseem");
            //HashTable1.Set("2", "ahmed");
            //HashTable1.Set("3", "omer");
            //HashTable1.Set("4", "ali");

            string ex1 = "Once upon a time, there was a brave princess who...";
            string ex2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string ex3 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";


            Console.WriteLine(RepeatedWord(ex1));
            Console.WriteLine(RepeatedWord(ex2));
            Console.WriteLine(RepeatedWord(ex3));

        }
        public static string RepeatedWord(string phrase)
        {
            string[] words = phrase.Split(' ');

            HashTable hashtable = new HashTable();

            for (int i = 0; i < words.Length; i++)
            {
                string word = Regex.Replace(words[i].ToLower(), @"[^\w\d\s]", "");

                if (hashtable.Contains(word))
                {
                    return hashtable.Get(word).Value;
                }

                hashtable.Set(word, word);
            }

            return "No Repeated Word";
        }
    }
}
