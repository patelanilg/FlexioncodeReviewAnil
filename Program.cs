using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexionCodeReview
{
    public class Program
   {
       public static void Main(string[] args)
       {
           double side1 = 0;
           double side2 = 0;
           double side3 = 0;
           side1 = Convert.ToDouble(Console.ReadLine());
           side2 = Convert.ToDouble(Console.ReadLine());
           side3 = Convert.ToDouble(Console.ReadLine());
           checktriangle(side1, side2, side3);           
           Console.ReadLine();
       }
 
       public static void checktriangle(double side1, double side2, double side3)
       {
           try
           {
 
               //checked if any side of triagle is not zero
               if (side1 <= 0 || side2 <= 0 || side3 <= 0)
               {
                   Console.WriteLine("Triangle.Error");
               }
 
               //check for triangle inequality theorem
 
               if (((side2 + side3) < side1) || ((side1 + side3) < side2) || ((side1 + side2) < side3))
 
               {
                   Console.WriteLine("Not a Triangle");
 
               }
               //check if all sides are equal
               if (side1 == side2 && side1 == side3)
               {
                   Console.WriteLine("Triangle.Equilateral");
               }
               else if (side1 == side2 || side1 == side3 || side2 == side3) //check if any two sides are equal
               {
                   Console.WriteLine("Triangle.Isosceles");
               }
               else if (side1 != side2 || side1 != side3 || side2 != side3) //this block will be executed of none of the sides are equal
               {
                   Console.WriteLine("Triangle.Scalene");
               }
               else
               {
                   Console.WriteLine("Triangle.NotTriangle");
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }         
       }
               
   }
}
