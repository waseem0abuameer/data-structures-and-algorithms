using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {


            HashTable HashTable1 = new HashTable();

            HashTable1.Set("1", "waseem");
            HashTable1.Set("2", "ahmed");
            HashTable1.Set("3", "omer");
            HashTable1.Set("4", "ali");
            



        }

        public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            List<string> Result = new List<string>();

            for (int i = 0; i < left.store.Length; i++)
            {
                if (left.store[i] != null)
                {
                    Node currentNode = left.store[i];

                    while (currentNode != null)
                    {
                        string concat = null;
                        concat = concat + $"{currentNode.Key}, {currentNode.Value}, ";
                        if (right.Contains(currentNode.Key))
                        {
                            concat = concat + right.Get(currentNode.Key);
                        }
                        else
                        {
                            concat += "NULL";
                        }
                        Result.Add(concat);
                        currentNode = currentNode.Next;
                    }
                }
            }

            return Result;
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
        public static bool uniquecharacters(string phrase)
        {

            string[] words = phrase.Select(x => x.ToString()).ToArray();

            HashTable hashtable = new HashTable();

            for (int i = 0; i < words.Length; i++)
            {
                string word = Regex.Replace(words[i].ToLower(), @"[^\w\d\s]", "");

                if (words[i]==" ")
                {
                    continue;
                }
                else if(hashtable.Contains(word))
                {
                    return false;
                }
                hashtable.Set(word, word);
            }

            return true;
        }

       
    }
}
