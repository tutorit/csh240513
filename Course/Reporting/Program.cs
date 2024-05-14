using Syntax;
using Reporting;

Console.WriteLine("Reporting");

//Console.WriteLine("Henkilö "+p);

static void ReportingV1()
{
    Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));
    ScreenReporter rep = new ScreenReporter();
    rep.BeginReport("Person info");
    rep.PrintData("Name", p.Name);
    rep.PrintData("Birthday", p.Birthday);
    rep.PrintData("Email", p.Email);
    //rep.PrintData("Address", "Teststreet 13");
    rep.PrintData("Age", 15);
    rep.EndReport("");
}

Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));

ScreenReporter srep = new ScreenReporter();
FileReporter frep=new FileReporter(@"c:\demodata\person.txt");

PersonReport pr = new PersonReport(p,frep);
pr.DoReport();