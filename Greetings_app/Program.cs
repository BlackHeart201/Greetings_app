using System;

namespace Greetings
{
    class Welcome
    {
        static void Main(string[] args) 
        {
            string name;
            int age;
            char sex;

            string generalQuestion = "What's your ";
            string nameQuestion = generalQuestion + "name?";
            string ageQuestion = generalQuestion + "age?";
            string sexQuestion = generalQuestion + "sex?";

            string femaleGreetings = "Hello Ms. ";
            string maleGreetings = "Hello Mrs. ";

            string greetingsEnding = " years old. Nice to meet you!";

            Console.WriteLine(nameQuestion);

            name = Console.ReadLine();

            Console.WriteLine(ageQuestion);

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sexQuestion);

            sex = Convert.ToChar(Console.ReadLine());

            if (sex == 'M')
                Console.WriteLine(maleGreetings + name + ", " + age + greetingsEnding);
            else
                Console.WriteLine(femaleGreetings + name + ", " + age + greetingsEnding);
        }
    }

}