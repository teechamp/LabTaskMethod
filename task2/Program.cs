using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();
            double side1 = 3;
            double  side2 = 4; 
    Console.Write($"The hypotenuse of the right angles triangle is:{task.Hypotenuse(side1, side2)}");

        }
    }
}
