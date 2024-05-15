using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    [Reporting("Soita")]
    public class Company : IComparable<Company>
    {
        [Reporting("Tähän")]
        public string Name { get; set; }
        public string Address { get;set; }
        [Reporting("Numeroon")]
        public string Phone { get; set; }

        public int CompareTo(Company other)
        {
            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            Company c=obj as Company;
            if (c == null) return false;
            if (c.Name!=this.Name) return false;
            if (c.Phone!=this.Phone) return false;
            if (c.Address!=this.Address) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
