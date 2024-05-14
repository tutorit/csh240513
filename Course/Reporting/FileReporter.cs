using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    internal class FileReporter : ReporterBase,IReporter
    {
        private string filename;
        private StreamWriter writer;
        public FileReporter(string filename)
        {
            this.filename = filename;
        }

        public void BeginReport(string title)
        {
            writer = new StreamWriter(filename);
            writer.WriteLine(title);
        }
        
        public void EndReport(string footer)
        {
            writer.WriteLine(footer);
            writer.Flush();
            writer.Close();
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
