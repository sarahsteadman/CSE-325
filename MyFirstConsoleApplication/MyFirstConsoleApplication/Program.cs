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
            string hobby = "Knit";

            DateTime date = DateTime.Now;
            DateTime christmas = new DateTime(date.Year, 12, 25);
            if (christmas < date)
                christmas = christmas.AddYears(1);

            Console.WriteLine($"Hi! My name is {name}! I am from {location}. I like to {hobby}.");
            Console.WriteLine($"The date is {date.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"There are {(christmas - date).Days} days until Christmas");
            Console.WriteLine();

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width of the wood:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter the height of the wood:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();


        }
    }
}
