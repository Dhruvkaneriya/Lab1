using System;

namespace Lab1.Geometry2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            p.SetCoords(2, 2);
            p.SetCoords(null, 2);

            Vector v = new Vector();
            v.Set(-1, 1);

            Rectangle r = new Rectangle(2,3);
            r.Area_of_rectangle(2, 3);
        }
    }
}
