using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC3
    {
       
         
            public static double lenthLine1 = UC1.GetDistance();
            public static double lenthLine2 = UC2.Equals();
            

            public static void compare()
            {

                if (lenthLine2 > lenthLine1)
                {
                    Console.WriteLine("Line 2 is greater than Line 1");
                }
                else
                {
                    Console.WriteLine("Line 2 is smaller than Line 1");
                }
            }
    }
}
