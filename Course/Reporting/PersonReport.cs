using Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    internal class PersonReport : Report // : FileReporter
    {
        private Person data;
        private IReporter reporter;

        public PersonReport(Person data,IReporter reporter)
        {
            this.data = data;
            this.reporter= reporter;
        }   

        public override void DoReport()
        {
            reporter.BeginReport("Henkilöraportti");
            reporter.PrintData("Name", data.Name);
            reporter.PrintData("Email", data.Email);
            reporter.PrintData("Birthday", data.Birthday);
            reporter.PrintData("Age", data.Age);
            reporter.EndReport("");
        }
    }
}
