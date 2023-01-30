namespace Math_Game.Models;

internal class Game
{
    //private int _score;

    //public int Score
    //{
    //    get { return _score; }
    //    set { _score = value; }
    //}
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
    public TimeSpan GameTime { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

//Add game difficulty as enum.
