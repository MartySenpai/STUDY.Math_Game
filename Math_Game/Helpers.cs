using Math_Game.Models;

namespace Math_Game
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts Time: {game.GameTime:mm\\:ss\\:ff}");
            }
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, GameType gameType, TimeSpan timeTaken)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                GameTime = timeTaken
            });
        }
        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 101);
            int secondNumber = random.Next(1, 101);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 101);
                secondNumber = random.Next(1, 101);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer, Try again.");
                result = Console.ReadLine();
            }
            return result;
        }
        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            string? name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }
            return name;
        }
        //Add validate and difficulty select as helper
    }
}
