using System;

namespace stringbuilder1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "hello";
            string word2 = word;
            word2 = "hi";
            Console.WriteLine(word);
        }
    }
}
