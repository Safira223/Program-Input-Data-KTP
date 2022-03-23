using System;
using System.Text;
using System.Collections.Generic;

   class Soal5 {
      static void Main(string[] args) {
         int num, next_digit, digit;
         int[] r = new int[10];
        
         string[] words = {"zero","one","two","three","four","five","six","seven","eight","nine"};
         
         Console.Write("Enter any number : ");
         num = Convert.ToInt32(Console.ReadLine());
         Console.Write("Numbers in words : ");
         next_digit = 0;
         digit = 0;
         do {
            next_digit = num % 10;
            r[digit] = next_digit;
            digit++;
            num = num / 10;
         } while (num > 0);
         digit--;
         for (; digit >= 0; digit--)
         Console.Write(words[r[digit]] + " ");
         Console.ReadLine();
      }
   }

 