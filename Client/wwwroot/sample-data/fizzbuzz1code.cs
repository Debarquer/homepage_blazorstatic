using System;

class FizzBuzz1
{
    static void Main(string[] args)
    {
        //string[] s = args[0].Split(" ");

        string[] s = "3 5 7".Split(" ");

        int X = int.Parse(s[0]);
        int Y = int.Parse(s[1]);
        int N = int.Parse(s[2]);

        for (int i = 1; i <= N; i++)
        {
            if (i % X == 0 && i % Y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % X == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % Y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}