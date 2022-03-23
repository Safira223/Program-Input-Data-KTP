  using System;

class Soal1 
{
    public static void Main(string[] args)
    {
        int n;
        string huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Console.Write("n = ");
        n = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= n; i++) 
        {
            int a = 0;
            for (int j = 0; j < n + i; j++)
            {
                if (j > n-i)
                {
                    if (a < huruf.Length)
                    {
                        if (j >= n)
                        Console.Write(huruf[a--]);
                        else
                        Console.Write(huruf[a++]);
                    }
                    else
                    {
                        if (j >= n)
                        Console.Write(huruf[huruf.Length%a--]);
                        else
                        Console.Write(huruf[huruf.Length%a++]);
                    }
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}