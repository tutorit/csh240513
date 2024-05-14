// See https://aka.ms/new-console-template for more information
using Syntax;
using System.Security.Cryptography;

static int PromptForInt(string prompt)
{
    int ret = 0;
    bool isValid=false;
    while (!isValid)
    {
        Console.Write(prompt);
        string input=Console.ReadLine();
        isValid = int.TryParse(input, out ret);
        if (!isValid) Console.WriteLine("Not a number");
    }
    return ret;
}
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
        //string guessString = Console.ReadLine();
        //bool isValid = int.TryParse(guessString, out int guess);
        int guess = PromptForInt("Guess a number (1-100):");
        if (/*!isValid || */(guess < 1) || (guess > 100))
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

//ArvausPeli();


/*
int i = 32;
var j = 64;

dynamic k = 32;
Console.WriteLine("K " + k + ", " + k.GetType());
k = "Terve";
Console.WriteLine("K " + k + ", " + k.GetType());
*/


static void ListDemo()
{
    //string weekdays = "Mon,Tue,Wed,Thu,Fri";
    //string[] wda = weekdays.Split(',');
    string[] wda = { "Mon", "Tue", "Wed", "Thu", "Fri" };
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

//ListDemo();


static int Laske(Luku l,ref int a,out int b)
{
    b = 72;
    a += 2;
    l.arvo = 6;
    l = new Luku();
    l.arvo = 20;
    return a + b;
}

static void OutRefDemo()
{
    int x = 5;
    //int y = 1;
    Luku l = new Luku();
    l.arvo = 8;
    Console.WriteLine("Laske " + Laske(l, ref x, out int y));
    Console.WriteLine("X=" + x + ", " + l.arvo + ", y=" + y);
}

static void NullablesDemo()
{
    Luku? l = null;
    int? i = null;
    Nullable<int> i2 = null;
    DateTime? dt = null;

    l = new Luku();

    l = null;
}

static void CarDemo()
{
    Car c = new Car() { Make = "Saab" };
    c.Make = "Volvo";
    c.Speed = 150;
    Car c2 = new Car();
    c2.Make = "Saab";
    Console.WriteLine("Make " + c.Make + ", " + c.Speed);
}

static void PersonTester(Person p)
{
    Console.WriteLine("Tester: " + p);
    p.DoSomeWork();
}

Person p = new ("Jussi") { Email="jussi@koe.com",BirthdayString="1.2.1980"};
//p.Name = "Matti";
Console.WriteLine(p.Name+","+p.Email+","+p.Birthday);
p.Name = "";
p.Birthday = DateOnly.Parse("2.6.2024");
//p.Email = null;
Console.WriteLine("First: "+p.Name + "," + p.Email + "," + p.Birthday);
Person p2 = new Person("Jussi", "jussi@koe.com", DateOnly.Parse("1.2.1980"));
Console.WriteLine("Second: "+p2.Name + "," + p2.Email + "," + p2.Birthday);
Console.WriteLine("Person " + p);
Console.WriteLine("Person == " + (p == p2));


p.DoSomeWork();
PersonTester(p);
Employee e = new Employee("Taavi", 4000);
e.DoSomeWork();
PersonTester(e);

Console.WriteLine("We have " + (Person.NextID-1) + " persons");

Customer c1 = new Customer("Mikko", 2000);
Customer c2 = new Customer("Matti", 3000);
Customer c3 = new Customer("Mikko", 2000);

//c2.Name = "Teuvo";

Console.WriteLine("Customer " + c1);
Console.WriteLine("Customers 1 and 2: "+(c1 == c2));
Console.WriteLine("Customers 1 and 3: "+(c1 == c3));


string tx = "Terve maailma";
Console.WriteLine("Vasen: " + tx.Substring(0, 3));
Console.WriteLine("Oikea: " + tx.Substring(tx.Length - 3));
//string x = MyExtensions.Left(tx, 3);
Console.WriteLine("Vasen: " + tx.Left(3));
Console.WriteLine("Oikea: " + tx.Right(3));

static void ShowAndIncrement(Vector v)
{
    v.i += 4;
    v.j += 5;
    Console.WriteLine("At vector test "+v.i+","+v.j);
}

Vector v = new Vector(1, 2);
Vector v2 = new Vector(1, 2);

Console.WriteLine("Vector " + v);
ShowAndIncrement(v);
Console.WriteLine("Main " + v.i + "," + v.j);
Console.WriteLine("Vector ==" + (v == v2));

class Luku
{
    public int arvo;
}
