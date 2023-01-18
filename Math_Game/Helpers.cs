using Math_Game.Models;

namespace Math_Game
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>()
        {
            //new game { date = datetime.now.adddays(1), type = gametype.addition, score = 5 },
            //new game { date = datetime.now.adddays(2), type = gametype.multiplication, score = 4 },
            //new game { date = datetime.now.adddays(3), type = gametype.division, score = 4 },
            //new game { date = datetime.now.adddays(4), type = gametype.subtraction, score = 3 },
            //new game { date = datetime.now.adddays(5), type = gametype.addition, score = 1 },
            //new game { date = datetime.now.adddays(6), type = gametype.multiplication, score = 2 },
            //new game { date = datetime.now.adddays(7), type = gametype.division, score = 3 },
            //new game { date = datetime.now.adddays(8), type = gametype.subtraction, score = 4 },
            //new game { date = datetime.now.adddays(9), type = gametype.addition, score = 4 },
            //new game { date = datetime.now.adddays(10), type = gametype.multiplication, score = 1 },
            //new game { date = datetime.now.adddays(11), type = gametype.subtraction, score = 0 },
            //new game { date = datetime.now.adddays(12), type = gametype.division, score = 2 },
            //new game { date = datetime.now.adddays(13), type = gametype.subtraction, score = 5 },
        };
        internal static void PrintGames()
        {
            //IEnumerable<Game> gamesToPrint = games.Where(x => x.Type == GameType.Division);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
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
    }
}
