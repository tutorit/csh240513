using Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    internal class CompanyReport : Report
    {
        private Company data;
        private IReporter reporter;

        public CompanyReport(Company data, IReporter reporter)
        {
            this.data = data;
            this.reporter = reporter;
        }

        public override void DoReport()
        {
            reporter.BeginReport("Yritys");
            reporter.PrintData("Name", data.Name);
            reporter.PrintData("Phone", data.Phone);
            reporter.EndReport("Loppu");
        }
    }
}
