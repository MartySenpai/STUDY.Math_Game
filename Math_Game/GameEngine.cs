using Math_Game.Models;
using System.Diagnostics;

namespace Math_Game
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            string difficulty = Menu.ShowDifficultyMenu();

            int nQuestions = Helpers.GetAmountOfQuestions();

            char operand = '+';

            var score = 0;

            List<int> numbers = new List<int>();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < nQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                numbers.Clear();

                Helpers.PrintQuestions(difficulty, numbers, operand);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == numbers.Sum())
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == nQuestions - 1)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, nQuestions, GameType.Addition, difficulty, timeTaken);
        }
        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            string difficulty = Menu.ShowDifficultyMenu();

            int nQuestions = Helpers.GetAmountOfQuestions();

            char operand = '-';

            var score = 0;

            List<int> numbers = new List<int>();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < nQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                numbers.Clear();

                Helpers.PrintQuestions(difficulty, numbers, operand);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                int difference = numbers[0];

                for (int j = 1; j < numbers.Count; j++)
                {
                    difference -= numbers[j];
                }

                if (int.Parse(result) == difference)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == nQuestions - 1)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, nQuestions, GameType.Subtraction, difficulty, timeTaken);

        }
        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            string difficulty = Menu.ShowDifficultyMenu();

            int nQuestions = Helpers.GetAmountOfQuestions();

            char operand = '*';

            var score = 0;

            List<int> numbers = new List<int>();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < nQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                numbers.Clear();

                Helpers.PrintQuestions(difficulty, numbers, operand);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                int product = numbers[0];

                for (int j = 1; j < numbers.Count; j++)
                {
                    product *= numbers[j];
                }

                if (int.Parse(result) == product)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == nQuestions - 1)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, nQuestions, GameType.Multiplication, difficulty, timeTaken);
        }
        //Add Diffuculty for DivisionGame
        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);

            string difficulty = Menu.ShowDifficultyMenu();

            int nQuestions = Helpers.GetAmountOfQuestions();

            int score = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < nQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == nQuestions - 1)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

           Helpers.AddToHistory(score,nQuestions, GameType.Division, difficulty, timeTaken);
        }
    }
}
