using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '*');
            p2.Draw();

            HorizontalLine Line = new HorizontalLine(5, 10, 8 , '+');
            Line.Drow();

            HorizontalLine Line1 = new HorizontalLine(10, 17, 23, '+');
            Line1.Drow();

            HorizontalLine Line2 = new HorizontalLine(14, 24, 9, '#');
            Line2.Drow();

           VerticalLine Line3 = new VerticalLine(45, 9, 20, '#');
            Line3.Drow();

            Console.ReadLine();

        }
        
            }
    
}
