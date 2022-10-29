using System;
using System.Linq.Expressions;

namespace Greetings
{
    class Welcome
    {
        static void Main(string[] args) 
        {
            string generalQuestion = "What's your ";
            string nameQuestion = generalQuestion + "name?";
            string ageQuestion = generalQuestion + "age?";
            string sexQuestion = generalQuestion + "sex?";
            string greetingsEnding = " years old. Nice to meet you!";

            string femaleGreetings = "Hello Ms. ";
            string maleGreetings = "Hello Mrs. ";

            try
            {
                Console.WriteLine(nameQuestion);
                string name = Console.ReadLine();

                Console.WriteLine(ageQuestion);
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(sexQuestion);
                char sex = Convert.ToChar(Console.ReadLine());

                if (sex == 'M' || sex == 'm')
                    Console.WriteLine(maleGreetings + name + ", " + age + greetingsEnding);

                else if (sex == 'F' || sex == 'f')
                    Console.WriteLine(femaleGreetings + name + ", " + age + greetingsEnding);

                else
                    Console.WriteLine("Given sex has incorect value");

            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}