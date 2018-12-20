using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
        public static class Painting
        {
            public static Bitmap DrawAxis(int width, int height)
            {
                Bitmap bmp = new Bitmap(width, height);
                Graphics grf = Graphics.FromImage(bmp);
                PointF X1 = new PointF(0, height / 2);
            PointF X2 = new PointF(width, height / 2);
            PointF Y1 = new PointF(width / 2, 0);
            PointF Y2 = new PointF(width / 2, height);
                Pen blackpen = new Pen(Color.Black);

                grf.DrawLine(blackpen, X1, X2);
                grf.DrawLine(blackpen, Y1, Y2);


                return bmp;
            }

            public static Bitmap DrawLine(Bitmap bmp, Line line)
            {
                Pen redpen = new Pen(Color.Red);
                Graphics grf = Graphics.FromImage(bmp);

                PointF prev = line.Lines.First();

                foreach (PointF p in line.Lines)
                {
                    grf.DrawLine(redpen, prev, p);
                    prev = p;
                }
                return bmp;
            }
        }
    }
