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

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"What is the radius of your circle? {r}");

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}");



            //----Thought Exercise

            var d = 3;

            var j = 4;
            var k = ++d * j++;

            Console.WriteLine(k);


        }
    }
}           
