using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line
{
    internal class UC2
    {
        int x1 = 2;
        int y1 = 3;

        int x2 = 4;
        int y2 = 1;

        int x11 = 3;
        int y11 = 4;

        int x12 = 4;
        int y12 = 5;

        public void EqualityOfLines()
        {
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            Console.WriteLine("length of 1st line: " + Math.Sqrt(z));
            int u = (x11 - y12) * (x11 - x12);
            int v = (y11 + y12) * (y11 - y12);
            int w = u + v;
            Console.WriteLine("Length of the 2nd Line:" + Math.Sqrt(w));

            if (z == w)
            {
                Console.WriteLine("The Two Lines are equals");

            }
            else if (z > w)
            {
                Console.WriteLine("The Two Lines are nott equal and 1st one is greater than the 2nd one");

            }
            else
            {
                Console.WriteLine("The Two Lines are not equal and 1st one is less than 2nd one");
            }
        }

    }
}
