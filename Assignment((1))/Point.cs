using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1__
{
    internal struct Point
    {
        public double[] x;
        public double[] y;

        public Point(double x1, double y1, double x2, double y2)
        {

            x = new double[2];
            y = new double[2];
            x[0] = x1;
            y[0] = y1;
            x[1] = x2;
            y[1] = y2;
        }
        public double resultOfDistance()
        {
            double distance = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
            return distance;
        }
        public void result()
        {
            Console.WriteLine($" The result is {resultOfDistance()}");
        }

    }
}
