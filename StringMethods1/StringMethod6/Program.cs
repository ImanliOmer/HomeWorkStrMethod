using System;

namespace StringMethod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //covert array to stirng


            //string[] names = { "lorem", "ipsum" };
            // string word = string.Join(" , ", names);
            // Console.WriteLine(word);


            //convert string to array 

            string word = "lorem ipsum";
            string [] newArr= word.Split("");

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }


        }
    }
}
