using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal class Person
    {
        private string name = "No name";
        private string email = "";
        private DateOnly? birthday=null;

        public string Name { 
            get { 
                return name; 
            }
            set
            {
                //if (value == null) return;
                //if (value == "") return;
                if (!string.IsNullOrEmpty(value)) name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                //if (value!=null) email = value;
                //email = (value == null) ? "" : value;
                email = value ?? "";
            }
        }

        public DateOnly? Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (value == null) birthday = value;
                else if (value <= DateOnly.FromDateTime(DateTime.Now)) birthday = value;
            }
        }

        public string BirthdayString
        {
            get
            {
                return Birthday?.ToString() ?? "Not known";
            }
            set
            {
                Birthday=DateOnly.Parse(value);
            }
        }

    }
}
