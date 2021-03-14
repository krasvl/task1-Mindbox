using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Triangle : IFigure
    {
        public double Side1
        {
            get
            {
                return Side1;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The side cannot be less than zero");
                else
                    Side1 = value;
            }
        }
        public double Side2
        {
            get
            {
                return Side2;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The side cannot be less than zero");
                else
                    Side2 = value;
            }
        }
        public double Side3
        {
            get
            {
                return Side3;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The side cannot be less than zero");
                else
                    Side3 = value;
            }
        }

        public Triangle(double side1, double side2, double side3)
        {
            double[] sides = SortSides(side1, side2, side3);
            if (side3 >= side1 + side2)
                throw new Exception("There is no such triangle");

            Side1 = sides[0];
            Side2 = sides[1];
            Side3 = sides[2];
        }

        public double GetSquare()
        {
            double p = (Side1 + Side2 + Side3) / 2.0;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public bool IsRectangular()
        {
            if (Side1 * Side1 + Side2 * Side2 == Side3 * Side3)
                return true;
            else
                return false;
        }

        private double[] SortSides(double side1, double side2, double side3)
        {
            double[] sides = new double[] {side1, side2, side3 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (sides[j] > sides[j + 1])
                    {
                        var c = sides[j + 1];
                        sides[j + 1] = sides[j];
                        sides[j] = c;
                    }
                }
            }
            return sides;
        }

    }
}
