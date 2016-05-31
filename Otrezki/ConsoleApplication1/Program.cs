using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

         
            double xa, xb, ya, yb;

            Console.WriteLine("Input coordinates x1,x2,y1,y2:"); 
            xa = Convert.ToDouble(Console.ReadLine());
            xb = Convert.ToDouble(Console.ReadLine());
            ya = Convert.ToDouble(Console.ReadLine());
            yb = Convert.ToDouble(Console.ReadLine());
            double angle = Math.Acos((xa * xb + ya * yb) /( (Math.Sqrt(xa * xa + ya * ya)*Math.Sqrt(xb*xb+yb*yb) )) );
            angle=angle* 180/Math.PI;
            Console.WriteLine(angle.ToString());
            Console.ReadKey();
        }       
    }
}
