// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arvauspeli");
int secret = new Random().Next(100) + 1;
Console.WriteLine("Secret is " + secret);
//int guess = 0;
int numGuesses = 0;
while (true)
{
    Console.Write("Guess a number (1-100):");
    string guessString = Console.ReadLine();
    bool isValid=int.TryParse(guessString,out int guess);
    if (!isValid || (guess<1) || (guess > 100))
    {
        Console.WriteLine("Not between 1-100");
        continue;
    }
    numGuesses++;
    if (guess == secret) break;
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


