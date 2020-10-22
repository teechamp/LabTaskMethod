
using System;
namespace task2
{
    class Task 
  { 
       
       public double Hypotenuse(double side1, 
                                 double side2) 
      { 
        double result = Math.Sqrt((side1 * side1) +  
                             (side2 * side2)); 
        return result; 
      } 
}
}