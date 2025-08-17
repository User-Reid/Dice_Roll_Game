public class RandomNumberGeneration
{
  private int diceRoll;
  public int DiceRoll()
  {
    Random rnd = new Random();
    int diceRoll = rnd.Next(1, 7);
    System.Console.WriteLine($"The secret number is {diceRoll}");
    return diceRoll;
  }
}