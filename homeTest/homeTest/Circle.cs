using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTest
{
    public class Circle
    {
        public int x;
        public int y;
        public int r;
        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public void checkIntersect(Circle c)
        {
            double distSq =Math.Sqrt(Math.Pow(this.x - c.x,2) + Math.Pow(this.y - c.y, 2));
            double radSumSq = this.r + c.r;
            if (distSq <= radSumSq)
                Console.WriteLine("Circle intersect to each other.");
            else
                Console.WriteLine("Circle does not intersect to each other.");
        }
    }
}
