using System;

namespace Decesions7._19._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bob's Big Giveaway");
            //Console.WriteLine("Choose a door: 1, 2, or 3: ");
            //string userValue = Console.ReadLine();
            //string message = "";

            //if(userValue == "1")
            //{
            //     message = "You won a new car!";

            //}


            //else if (userValue == "2")
            //{
            //     message = "You won an all paid vacay to Italy!";


            //}


            //else if(userValue == "3")
            //{
            //    message = "You won a new custom made home!";

            //}
            //else
            //{
            //    message = "Sorry, we didn't understand";

            //}
            //Console.WriteLine(message);
            //Console.ReadLine();

            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.WriteLine ("You entered; {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}
