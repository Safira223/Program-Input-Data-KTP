using System;

public class Soal3
{
	public static void Main()
	{
	 int a;
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.In.ReadLine());
            a = 1;
            Console.Write(n + "! = ");

            for (int i = 1; i <= n; i++)
            {
                a = a * i;

                Console.Write(n - (i - 1));
                if (i != n)

                    Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("Factorial of {0} is = ", n);
            Console.WriteLine(a);
            Console.ReadLine();
	}
}