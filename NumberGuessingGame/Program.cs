using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number!" +
                "\nPick a number between 1 and 1000.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
                int.Parse(Console.ReadLine());
            }

            else if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.ReadLine();


            //Exercise 2

            Console.WriteLine("Welcome to Hogwarts. What is your favorite school subject?");
            string input = Console.ReadLine();
            string faveSubject = input.ToLower();

            switch (faveSubject)
            {
                case "potions":
                    Console.WriteLine("Professor Snape will be happy to hear that!");
                    break;
                case "divination":
                    Console.WriteLine("Ahh, we will see if that is in the cards for you!");
                    break;
                case "transfiguration":
                    Console.WriteLine("What's life without some change once in a while?");
                    break;
                case "charms":
                    Console.WriteLine("Just remember: It's Levi'O'sa, not Levios'A'.");
                    break;
                case "defense against the dark arts":
                case "dada":
                    Console.WriteLine("So I should come to you first if the school is under attack?");
                    break;
                case "history of magic":
                    Console.WriteLine("Oh, you must be the life of the party");
                    break;
                case "herbology":
                    Console.WriteLine("Maybe you can come help me with my garden sometime. " +
                        "\nMy tomatoes are looking dreadful this year.");
                    break;
                case "astronomy":
                    Console.WriteLine("An excellent subject!" +
                        "\nJust remember that stargazing is not an acceptable reason to be out past curfew.");
                    break;
                case "flying":
                    Console.WriteLine("I bet you're a quidditch fan. Who's your favorite team?");
                    var team = Console.ReadLine();
                    Console.WriteLine($"The players for {team} are looking great this year!");
                    break;
                default:
                    Console.WriteLine("Hmmm, I don't think you'll be able to get into that one this year.");
                    break;
            }


                Console.ReadLine();
            
        }
    }
}

