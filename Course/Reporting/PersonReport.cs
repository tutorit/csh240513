using Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    internal class PersonReport : Reporter
    {
        private Person data;

        public PersonReport(Person data)
        {
            this.data = data;
        }   

        public void DoReport()
        {
            this.BeginReport("Henkilöraportti");
            this.PrintData("Name", data.Name);
            this.PrintData("Email", data.Email);
            this.PrintData("Birthday", data.Birthday);
            this.PrintData("Age", data.Age);
            this.EndReport("");
        }
    }
}
