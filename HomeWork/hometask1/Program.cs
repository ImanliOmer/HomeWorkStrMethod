using System;

namespace hometask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -2, 3 };
            Arry(ref numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static int[] Arry(ref int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i]<0)
                {
                    Arr[i] *= -1;
                }
            }
            return Arr;
        }
    }
}
