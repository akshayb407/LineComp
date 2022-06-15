using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line
{
    internal class UC1
    {
        int x1 = 2;
        int y1 =3;

        int x2 = 1;
        int y2 = 2;
        public void Length ()
        {
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            Console.WriteLine("Length of the Line is :" + Math.Sqrt(z));

        }


    }


}
