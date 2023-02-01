using Math_Game.Models;
using System;

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
                Console.WriteLine($"{game.Date} - {game.Difficulty} - {game.Type} : {game.Score}/{game.NQuestions} pts - Time: {game.GameTime:mm\\:ss\\:ff}");
            }
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, int nQuestions, GameType gameType, string difficulty, TimeSpan timeTaken)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Difficulty = difficulty,
                GameTime = timeTaken,
                NQuestions = nQuestions
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
        internal static int GetAmountOfQuestions()
        {
            Console.Clear();
            Console.WriteLine("Please enter how many questions you would like to recieve.");

            string input = (Console.ReadLine());

            if (string.IsNullOrEmpty(input))
            {
                input = "5";
            }

            int amount = Int32.Parse(input);
            return amount;
        }

        internal static void PrintQuestions(string difficulty, List<int> numbers, char operand)
        {
            var random = new Random();

            int n = 0;

            switch (difficulty)
            {
                case "Easy":
                    n = 2;
                    break;
                case "Normal":
                    n = 3;
                    break;
                case "Hard":
                    n = 4;
                    break;
            }

            for (int j = 0; j < n; j++)
            {
                numbers.Add(random.Next(1, 11));
                if (j == n - 1)
                {
                    Console.Write($"{numbers[j]}\n");
                }
                else
                {
                    Console.Write($"{numbers[j]} {operand} ");
                }
            }
        }
    }
}
