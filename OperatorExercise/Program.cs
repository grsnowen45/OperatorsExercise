using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------Exercise 1-------------------


            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            //------------ Exercise 2------------------------


            Console.WriteLine($"Please enter a radius to calculate area of a circle:");


            var userInput = Console.ReadLine();

            var  radius = double.Parse(userInput);

            var area = AreaOfCircle(radius);


            Console.WriteLine($"{area} is the area of a circle with a radius of {radius}");




            //----Thought Exercise

            var d = 3;

            var j = 4;
            var k = ++d * j++;

            Console.WriteLine($"k: {k} j:{j}");

           
      


        }

        public static double AreaOfCircle(double radius)
        {
            return (Math.PI) * (radius * radius);
        
        }
    }
}           
