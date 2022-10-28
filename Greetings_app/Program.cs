using System;

namespace Greetings
{
    class Welcome
    {
        static void Main(string[] args) 
        {
            string name = "" ;

            string nameQuestion = "What's your name?";

            string welcomeGreetings = "Hello ";

            Console.WriteLine(nameQuestion);

            name = Console.ReadLine();

            Console.WriteLine(welcomeGreetings + name);

        }
    }

}