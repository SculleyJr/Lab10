using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CircleApp;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            var numberOfCircles = new List<double>();
            bool str = true;
            do
            {
               

                Console.WriteLine("Enter a radius: ");
                try
                {
                    double radius = double.Parse(Console.ReadLine());
                    var circle = new Circle(radius);
                    circle.GiverFormatCircumfrance();
                    circle.GiverFormatArea();
                    numberOfCircles.Add(circle.Circumfrance);
                 

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input");
                }
               
                


                
                Console.WriteLine("Press 'Y' to make another circle");
                string ans = Console.ReadLine();
                if (ans.ToLower() == "y")
                {
                    str = true;

                }
                else
                {
                    str = false;
                }
            } while (str == true);

            Console.WriteLine($"Thank you! you created {numberOfCircles.Count} circles");
         
        }
    }
}
