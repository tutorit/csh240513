using Syntax;
using Reporting;

Console.WriteLine("Reporting");

Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));
//Console.WriteLine("Henkilö "+p);

Reporter rep = new Reporter();
rep.BeginReport("Person info");
rep.PrintData("Name", p.Name);
rep.PrintData("Birthday", p.Birthday);
rep.PrintData("Email", p.Email);
//rep.PrintData("Address", "Teststreet 13");
rep.PrintData("Age", 15);

rep.EndReport("");