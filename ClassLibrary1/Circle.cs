using System;

namespace ClassLibrary1
{
    public class Circle : IFigure
    {
        public double Radius 
        { 
            get 
            { 
                return Radius; 
            }
            set 
            {
                if (value < 0)
                    throw new Exception("The radius cannot be less than zero");
                else
                    Radius = value;
            } 
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
