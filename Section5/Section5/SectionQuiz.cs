using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionQuiz
    {
        // F to C subtract by 30 then divide by 2
        
        [TestMethod]
        public void Convert_F_To_C()
        {
            Console.WriteLine("What temperature is it outside in Fahrenheit?");
            string input = Console.ReadLine(); 
            int inputInt = Convert.ToInt32(input);
            double celsius = (inputInt - 30) / 2;
            Console.WriteLine($"The temp in F {input} is {celsius} C");

            //given the temperature in Fahrenheit use a math
            //expression to convert the temperature to Celsius
            //display an output string to the console that says
            //The temp in F {given temp} is {temp} in C
            //replacing the values as necessary in the string

        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            
            Console.WriteLine("What temperature is it outside in Celcius?");
            string input = Console.ReadLine(); 
            int inputInt = Convert.ToInt32(input);
            double fahrenheit = (inputInt / 5) + 32;
            Console.WriteLine($"The temp in C {input} is {fahrenheit} F");

            //given the temperature in Celsius use a math
            //expression to convert the temperature to Fahrenheit
            //display an output string to the console that says
            //The temp in C {given temp} is {temp} in F
            //replacing the values as necessary in the string
         
        }
    }
}
