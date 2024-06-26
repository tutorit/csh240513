﻿using Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    public delegate void ReportDelegate(string stage);
    internal abstract class Report
    {
        static public event ReportDelegate ReportEvent;
        abstract public void DoReport();

        public static Report Create(object o,string fn="",Formatter f=null)
        {
            IReporter rep = string.IsNullOrEmpty(fn) ? new ScreenReporter() : new FileReporter(fn);
            if (ReportEvent != null) ReportEvent("Reporter muodostettu");
            if (f != null) rep.Formatter = f;
            //if (o is Person) return new PersonReport(o as Person, rep);
            //if (o is Company) return new CompanyReport(o as Company, rep);
            //return null;
            Report? ret = o switch
            {
                Person => new PersonReport(o as Person, rep),
                Company => new CompanyReport(o as Company, rep),
                _ => null
            };
            ReportEvent?.Invoke("Raportti muodostettu");
            return ret;
        }

        public static Report Create(object o, Formatter f)
        {
            return Create(o, "", f);
        }
    }
}
