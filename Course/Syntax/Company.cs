using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    [Reporting("Soita")]
    public class Company
    {
        [Reporting("Tähän")]
        public string Name { get; set; }
        public string Address { get;set; }
        [Reporting("Numeroon")]
        public string Phone { get; set; }
    }
}
