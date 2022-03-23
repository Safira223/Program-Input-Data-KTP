using System;

class Soal4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any number : ");
        int input = int.Parse(Console.ReadLine());

        int reminder, reverse = 0;
        while (input>0)
        {
            reminder = input % 10;
            reverse = reverse *10 + reminder;
            input = input / 10;
        }
        Console.WriteLine($"Reverse bilangan : {reverse}");
    }
}