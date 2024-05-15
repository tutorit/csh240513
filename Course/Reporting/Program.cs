using Syntax;
using Reporting;
using System.Runtime.Intrinsics.Arm;

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

static void ReportingV2()
{
    Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));
    ScreenReporter srep = new ScreenReporter();
    FileReporter frep = new FileReporter(@"c:\demodata\person.txt");
    PersonReport pr = new PersonReport(p, srep);
    pr.DoReport();

}

static void ReportingV3()
{
    Formatter upper = (a, b) => $"{a.ToUpper()}={b}";
    Formatter xml = (a, b) => $"<{a}>{b}</{a}>";
    Formatter columns = (a, b) => $"{a.PadRight(20)}{b}";

    Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));

    ScreenReporter srep = new ScreenReporter();
    srep.Formatter = columns;
    FileReporter frep = new FileReporter(@"c:\demodata\person.txt");

    PersonReport pr = new PersonReport(p, srep);
    pr.DoReport();
}

Formatter upper = (a, b) => $"{a.ToUpper()}={b}";
Formatter xml = (a, b) => $"<{a}>{b}</{a}>";
Formatter columns = (a, b) => $"{a.PadRight(20)}{b}";

Person p = new Person("Tuomas", "tuomas@veljekset.net", new DateOnly(1980, 4, 2));


Report pr1 = Report.Create(p);
pr1?.DoReport();

Report pr2 = Report.Create(p,@"c:\demodata\person.txt",xml);
pr2?.DoReport();

Report pr3 = Report.Create(p,columns);
pr3?.DoReport();


Company c = new Company() { Name = "Coders unlimited", Phone="55523423", Address = "Bugstreet 12" };
Report cr1 = Report.Create(c);
cr1?.DoReport();



