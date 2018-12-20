using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
  public  class MyFunction
    {
        public double kX { get; set; }
        public double kY { get; set; }
        public double C { get; set; }

        public delegate double ActionForParam(double p);

        public ActionForParam ActionForX { get; set; }
        public ActionForParam ActionForY { get; set; }

        public MyFunction(double kx, double ky, double c, ActionForParam actionForX, ActionForParam actionForY)
        {
            kX = kx;
            kY = ky;
            C = c;
            ActionForX = actionForX;
            ActionForY = actionForY;
        }
        // проекция на плоскость C = f(x, y)
        public double Return(double x, double y)
        {
            return kX * ActionForX(x) + kY * ActionForY(y) + C;
        }

    }
}
