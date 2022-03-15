using System;
using System.Text;

namespace StringBuilder_Revers_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string ReversWord(string word)
        {
            int num = 5;

            StringBuilder newString = new StringBuilder();
            for (int i= word.Length-1; i >= 0; i--)
            {
               newString.Append(word[i]);   
            }
            return newString.ToString();
        }

    }
}
