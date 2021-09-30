using Lab2.Geometry2D;
using Lab2.Particles;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Vector p1 = new Vector();
            p1.Set(1, 1);

            Phonon p= new Phonon(1);

            System.Console.WriteLine(p);

            Point point = p.Position;

            point.SetCoords(100,100);

            System.Console.WriteLine(p);

            Phonon p2 = new Phonon(p); // making a copy of point p and store in p2
            Console.WriteLine(p2);

            Phonon p3 = new Phonon(0);
            p3.Drift(1);
            Console.WriteLine(p3);

        }
    }
}
