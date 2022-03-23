using System;

   class HelloWorld {
      static void Main(string[] args) {
         int val, next, num_digits;
         int[] a = new int[10];
        
         string[] digits_words = {"zero","one","two","three","four","five","six","seven","eight","nine"};
         
         Console.Write("Number = ");
         val = Convert.ToInt32(Console.ReadLine());
         Console.Write("Number (words) = ");
         next = 0;
         num_digits = 0;
         do {
            next = val % 10;
            a[num_digits] = next;
            num_digits++;
            val = val / 10;
         } while (val > 0);
         num_digits--;
         for (; num_digits >= 0; num_digits--)
         Console.Write(digits_words[a[num_digits]] + " ");
         Console.ReadLine();
      }
   }

 