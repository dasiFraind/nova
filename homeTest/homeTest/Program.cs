using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------2----------------------------
            void checkNumbers()
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % 4 == 0)
                        if (i % 7 == 0)
                            Console.WriteLine("FussBull");
                        else
                            Console.WriteLine("Fuss");
                    else
                        if (i % 7 == 0)
                        Console.WriteLine("Bull");
                    else
                        Console.WriteLine(i);
                }
            }

            checkNumbers();


            //-----------------3----------------------------

            //Intersect
            Circle c1 = new Circle(2,2, 5);
            Circle c2 = new Circle(3,4, 8);

            //not Intersect
            //Circle c1 = new Circle(-4, 3, 2);
            //Circle c2 = new Circle(0, 3, 2);

            c1.checkIntersect(c2);
            Console.ReadKey();
        }
    }
}
