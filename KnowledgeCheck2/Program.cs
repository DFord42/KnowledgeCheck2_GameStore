using GameStore;
using System.Text.Json;
namespace GameStore
{
    class GameStore
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var HandHeldVideoGameConsoles = new List<HandheldVideoGameConsole>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var handheldVideoGameConsole = new HandheldVideoGameConsole();

                Console.WriteLine("What is the name of the video game console you are adding?");
                handheldVideoGameConsole.ConsoleName = Console.ReadLine();

                Console.WriteLine($"Which company manufactured {handheldVideoGameConsole.ConsoleName}?");
                handheldVideoGameConsole.Manufacturer = Console.ReadLine();

                Console.WriteLine($"What year was {handheldVideoGameConsole.ConsoleName} released?");
                bool test = int.TryParse(Console.ReadLine(), out int ReleaseYear);
                handheldVideoGameConsole.ReleaseYear = ReleaseYear;

                Console.WriteLine($"How many buttons are on a {handheldVideoGameConsole.ConsoleName}'s controller?");
                test = int.TryParse(Console.ReadLine(), out int NumberOfButtons);
                handheldVideoGameConsole.NumberOfButtons = NumberOfButtons;

                Console.WriteLine($"Does {handheldVideoGameConsole.ConsoleName} have a touch screen?");
                bool result = ValidAnswerCheck(handheldVideoGameConsole);
                handheldVideoGameConsole.HasTouchScreen = result;

                Console.WriteLine($"How many hours long is the battery life of a {handheldVideoGameConsole.ConsoleName}?");
                test = double.TryParse(Console.ReadLine(), out double BatteryLife);
                handheldVideoGameConsole.BatteryLifeInHours = BatteryLife;


                Console.WriteLine($"Does a {handheldVideoGameConsole.ConsoleName} have more than one screen?");
                result = ValidAnswerCheck(handheldVideoGameConsole);
                handheldVideoGameConsole.HasMultipleScreens = result;


                HandHeldVideoGameConsoles.Add(handheldVideoGameConsole);
                Console.WriteLine("\n");
            }

            foreach (var GameConsole in HandHeldVideoGameConsoles)
            {
                string gameConsole = JsonSerializer.Serialize(GameConsole);
                Console.WriteLine(gameConsole);
            }
            Console.ReadKey();
        }


        private static bool ValidAnswerCheck(HandheldVideoGameConsole handheldVideoGameConsole)
        {
            string UserResponse = Console.ReadLine();
            bool check = true;
            bool ValidAnswer = false;
            while (ValidAnswer == false)
            {
                if (UserResponse.ToLower() == "yes")
                {
                    ValidAnswer = true;
                    check = true;
                }
                else if (UserResponse.ToLower() == "no")
                {
                    ValidAnswer = true;
                    check = false;
                }
                else
                {
                    Console.WriteLine("That was an invalid answer. Please type \"yes\" or \"no.\"");
                    UserResponse = Console.ReadLine();
                }
            }
            return check;
        }
    }

}