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

Formatter upper = (a, b) => $"{a.ToUpper()}={b}";
Formatter xml = (a, b) => $"<{a}>{b}</{a}>";
Formatter columns = (a, b) => $"{a.PadRight(20)}{b}";

Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));

ScreenReporter srep = new ScreenReporter();
srep.Formatter = columns;
FileReporter frep=new FileReporter(@"c:\demodata\person.txt");

PersonReport pr = new PersonReport(p,srep);
pr.DoReport();