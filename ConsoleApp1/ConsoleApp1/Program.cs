/*priyanka dhakal*/
/*student id = 30001935*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...............");
            Console.WriteLine("Question no 2");
            Console.WriteLine("......................");

            Console.WriteLine("calculate the price of five items");
            float total = 0;
            for (int i=1;  i<=5; i++) 
         
         Console.WriteLine($"Please enter number {i}:");
         total = total + float.Parse(Console.ReadLine());

         Console.WriteLine($"the sum of number you entered is :{total}");
         Console.WriteLine("press enter to quit");
         Console.ReadLine();
          
        }
        

    }
}

