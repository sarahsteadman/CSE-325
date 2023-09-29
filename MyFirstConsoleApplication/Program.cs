using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sarah Steadman";
            string location = "Vineyard Utah";
            Console.WriteLine($"My name is {name}, I am from {location}.");

            DateTime date = DateTime.Today;
            Console.WriteLine($"Today is {date.Month}/{date.Day}/{date.Year}");

            DateTime christmas = new DateTime(date.Year, 12, 25);
            if (date < christmas)
            {
                christmas.AddYears(1);
            }
            int countDown = (christmas - date).Days;
            Console.WriteLine($"There are {countDown} days until Christmas.");


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width of a board of wood.");
           widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of a board of wood.");
           heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();

        }
    }
}




