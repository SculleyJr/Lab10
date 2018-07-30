using System;
using System.Globalization;

namespace CircleApp
{
    public class Circle
    {
        private readonly double _radius;
        public double Circumfrance;
        public double Area;
        private double _formattedRadius;

        public  Circle(double radius)
        {
            this._radius = radius;
        }


        private double FormatCircumfrance(double radius)
        {

           Circumfrance = Math.Round(CalculateCircumfrance(),2);

            Convert.ToString(Circumfrance);


        return Circumfrance;
        }

       
        public double CalculateCircumfrance()
        {
            this.Circumfrance = (2 * Math.PI) * _radius;
            return Circumfrance;
        }

        public double CalculateArea()
        {
            this.Area = Math.PI * Math.Pow(_radius,2);
            return Area;
        }
        private double FormatArea(double radius)
        {

            Area = Math.Round(CalculateArea(), 2);

            Convert.ToString(Area);


            return Area;
        }
        public void GiverFormatArea()
        {
            Console.WriteLine("The Area is: {0}", FormatArea(_radius));

        }
        public void GiverFormatCircumfrance()
        {
            Console.WriteLine("The Circumfrance is: {0}",FormatCircumfrance(_radius));
        }
    }
}
