using System.Security.Cryptography;

RandomNumberGeneration randomNumber = new RandomNumberGeneration();
GuessValidation validation = new GuessValidation();

System.Console.WriteLine("Welcome to Dice Roll! Good Luck!");

randomNumber.DiceRoll();
validation.GuessValidater();

Console.ReadKey();