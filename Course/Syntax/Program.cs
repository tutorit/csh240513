// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arvauspeli");
int secret = new Random().Next(100) + 1;
Console.WriteLine("Secret is " + secret);
int guess = 0;
int numGuesses = 0;
while (guess != secret)
{
    Console.Write("Guess a number (1-100):");
    string guessString = Console.ReadLine();
    guess = int.Parse(guessString);
    if ((guess<0) || (guess > 100))
    {
        Console.WriteLine("Not between 1-100");
        continue;
    }
    numGuesses++;
    if (guess < secret)
    {
        Console.WriteLine("Too small");
    }
    if (guess > secret)
    {
        Console.WriteLine("Too big");
    }
}
Console.WriteLine($"You got it in {numGuesses} guesses");


