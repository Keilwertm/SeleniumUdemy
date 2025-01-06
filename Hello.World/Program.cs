using System;

namespace Hello.World
{
    class Program
    {
         int someNumber;
        static void Main(string[] args)
        {
            int number1 = 5;
            char holdsALetter = 'a';
            double amount;
            int sum;
            sum = number1 + number1;
            Console.WriteLine(sum.ToString());
            bool test = true;
            amount = 2.5;
            // ask the user a question
            Console.WriteLine("What is your favorite number?");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            string userFirstName;
            string age;
            
            Console.WriteLine("What is your first name?");
            userFirstName = Console.ReadLine();
            
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            
            string response = "Hello, " + userFirstName + " " + age;
            Console.WriteLine(response);

            var table = string.Format("{0, 10} {1,10}", "test", "2");
            var dollarFormat = string.Format("{0:C}",2);

            Console.WriteLine(table);
            Console.WriteLine(dollarFormat);

        }
    }
}
