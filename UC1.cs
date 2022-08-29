using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
   internal class UC1
    {
        
         
         public static double GetDistance()
         {
           // Co-ordinates of x
            Console.WriteLine("enter the value of x1 ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of x2 ");
            double  x2 = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("enter the value of y1 ");

            //Co-ordinates of y
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y2 ");
            double y2 = Convert.ToInt32(Console.ReadLine());

            //Calculating Length between two Co-ordinates
             Double lengthLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line 1 is "+lengthLine1);
             return lengthLine1;    
            //Console.WriteLine("Length of the line is  " + lengthLine1);
         }
        

    }
}
