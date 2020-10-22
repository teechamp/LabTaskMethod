using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
   
    Console.Write("please enter first number: ");
    int value1 = Convert.ToInt32(Console.ReadLine());

     Console.Write("please enter first number: ");
    int value2 = Convert.ToInt32(Console.ReadLine());

     Console.Write("please enter first number: ");
    int value3 = Convert.ToInt32(Console.ReadLine());
    
    int Minimum =Math.Min(value1, Math.Min(value2, value3));
  Console.WriteLine($"The minimum of the three numbers is {Minimum}");

        }
    }
}
