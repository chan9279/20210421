using System;

namespace _20210421
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(inputNumber + "X" + i + "=" + (inputNumber * i));
            }
        }
    }
}
