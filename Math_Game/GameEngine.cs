﻿using Math_Game.Models;
using System.Diagnostics;

namespace Math_Game
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(@$"
Please choose a difficulty option:
1 - Easy
2 - Normal
3 - Hard
C - Custom");

            string difficultSelected = Console.ReadLine();

            int n = Helpers.DifficultySelect(difficultSelected);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 11);
                secondNumber = random.Next(1, 11);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
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

                if (i == n - 1)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, GameType.Addition, timeTaken);
        }
        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 11);
                secondNumber = random.Next(1, 11);

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
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

                if (i == 4)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, GameType.Subtraction, timeTaken);

        }
        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 11);
                secondNumber = random.Next(1, 11);

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
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

                if (i == 4)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, GameType.Multiplication, timeTaken);
        }
        internal void DivisionGame(string message)
        {
            int score = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 5; i++)
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

                if (i == 4)
                {
                    Console.WriteLine($"Game over, Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Helpers.AddToHistory(score, GameType.Division, timeTaken);
        }
    }
}
