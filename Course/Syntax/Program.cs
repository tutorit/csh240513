// See https://aka.ms/new-console-template for more information


static void ArvausPeli()
{
    Console.WriteLine("Arvauspeli");
    int secret = new Random().Next(100) + 1;
    Console.WriteLine("Secret is " + secret);
    //int guess = 0;
    int numGuesses = 0;
    while (true)
    {
        Console.Write("Guess a number (1-100):");
        string guessString = Console.ReadLine();
        bool isValid = int.TryParse(guessString, out int guess);
        if (!isValid || (guess < 1) || (guess > 100))
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
}

/*
int i = 32;
var j = 64;

dynamic k = 32;
Console.WriteLine("K " + k + ", " + k.GetType());
k = "Terve";
Console.WriteLine("K " + k + ", " + k.GetType());
*/

//ArvausPeli();

static void ListDemo()
{
    string weekdays = "Mon,Tue,Wed,Thu,Fri";
    string[] wda = weekdays.Split(',');
    foreach (string s in wda) Console.WriteLine(s);
    List<string> wdl = new List<string>(wda);
    wdl.RemoveAt(0);
    wdl.Insert(0, "Sun");
    wdl.Add("Sat");
    foreach (string s in wdl) Console.WriteLine(s);

    Console.WriteLine("Hat? " + wda[^1] + ", " + wdl[^1]);
    var waRange = wda[2..4];
    foreach (string s in waRange) Console.WriteLine(s);
    //var wlRange = wdl[1..4];
}

ListDemo();



