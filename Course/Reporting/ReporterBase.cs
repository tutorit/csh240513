using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    internal abstract class ReporterBase
    {
        private TextWriter writer;

        public abstract TextWriter GetWriter();
        public abstract void CloseWriter(TextWriter writer);

        public void BeginReport(string title)
        {
            writer =GetWriter();
            writer.WriteLine(title);
        }

        public void EndReport(string footer)
        {
            writer.WriteLine(footer);
            CloseWriter(writer);
        }

        public void PrintData(string title, string data)
        {
            writer.WriteLine(title + "=" + data);
        }

        public void PrintData(string title, DateOnly? dt)
        {
            PrintData(title, dt?.ToString() ?? "Not known");
        }

        public void PrintData(string title, int? data)
        {
            PrintData(title, data?.ToString() ?? "NaN");
        }
    }
}
