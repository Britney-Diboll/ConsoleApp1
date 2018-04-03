using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World");

            const int numberOfDogs = 5;
            const int sandwiches = 2;
            const int money = 50;
            const int monthDay = 3;
            const int year = 2018;
            string month = " April ";
            string starsInSky = "too many to count";
            string dreamCar = "Beetle ";
            string carColor = "Forest Green";
            string modelCar = "VW ";
            char firstInitial = 'B';

            Console.WriteLine("There are " + numberOfDogs + " dogs running around the park");
            Console.WriteLine("I can eat " + sandwiches + " sandwiches when I am hungry");
            Console.WriteLine("It cost $" + money + " to buy a nice dinner");
            Console.WriteLine("My dream car is a " + modelCar + dreamCar + "in the color " + carColor);
            Console.WriteLine("Today's date is: " + monthDay + month + year);
            Console.WriteLine("The first letter in my first name is " + firstInitial);
            Console.WriteLine("The number of stars in the sky is " + starsInSky);

            Console.ReadLine();
        }
    }
}
