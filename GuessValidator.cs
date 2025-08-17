class GuessValidation
{
  public int GuessValidater()
  {
    int userGuess;
    while (true)
    {
    System.Console.WriteLine("Try to guess the dice roll!");
    string userInput = Console.ReadLine();
    if (int.TryParse(userInput, out userGuess))
    {
      if (userGuess >= 1 && userGuess <= 6)
      {
        return userGuess;
      }
      else
      {
        System.Console.WriteLine("Please enter a number between 1-6");
      }
    }
    else
    {
      System.Console.WriteLine("Please enter a whole number between 1-6");
    }
    }
  }
}