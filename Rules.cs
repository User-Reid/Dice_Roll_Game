using System.Diagnostics;

class Rules
{
  private int diceRoll;
  private int lifeTotal = 3;
  private int guess;
  public int DiceRoll()
  {
    Random rnd = new Random();
    diceRoll = rnd.Next(1, 7);
    return diceRoll;
  }

  public void GameMechanics()
  {
    GuessValidation validation = new GuessValidation();

    System.Console.WriteLine("Guess the dice roll!");
    guess = validation.GuessValidater();
    
      while (guess != diceRoll && lifeTotal > 0)
      {
        string newGuess;
        System.Console.WriteLine("Sorry, wrong guess, try again");
        LifeCount();
      if (lifeTotal > 0)
      {
        guess = validation.GuessValidater();
      }
      }
    if (guess == diceRoll)
    {
      System.Console.WriteLine("You win!");
    }
    else
    {
        
    System.Console.WriteLine($"The secret number is {diceRoll}");
      System.Console.WriteLine("You lose.😔");
      }
  }

  public int LifeCount() {
    return lifeTotal--;
  }
  }
