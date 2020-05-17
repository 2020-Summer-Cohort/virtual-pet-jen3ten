using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();

            Console.WriteLine("Hello! Welcome to Virtual Pets\n");

            Console.WriteLine("You have a new Virtual Pet.  What kind of pet is it?");
            myPet.SetSpecies(Console.ReadLine());

            Console.WriteLine("What is your pet's name?"); 
            myPet.SetName(Console.ReadLine());

            Console.WriteLine($"{myPet.GetName()} the {myPet.GetSpecies()} is ready to play with you!\n\n");
            Console.WriteLine("Press any key to start playing...");
            Console.ReadKey();
            Console.Clear();

            bool playGame = true;
            do
            {
                myPet.Tick();

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. See my pet's status");
                Console.WriteLine("2. Play with my pet.");
                Console.WriteLine("3. Feed my pet.");
                Console.WriteLine("4. Take my pet to the doctor.");
                Console.WriteLine("5. Quit");

                string gameAction = Console.ReadLine();
                Console.Clear();

                switch (gameAction)
                {
                    case "1":
                        myPet.ShowStatus();
                        break;
                    case "2":
                        myPet.Play();
                        break;
                    case "3":
                        myPet.Feed();
                        break;
                    case "4":
                        myPet.SeeDoctor();
                        break;
                    case "5":
                        Console.WriteLine("Your pet will miss you!  Good-bye.");
                        playGame = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }


            } while (playGame);
        }
    }
}
