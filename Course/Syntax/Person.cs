using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    public class Person
    {
        private string name = "No name";
        private string email = "";
        private DateOnly? birthday=null;
        public int Id { get; private set; }
        public static int NextID=1;

        public Person(string name,string email="",DateOnly? bd=null) 
        {
            Name = name;
            Email = email;
            Birthday = bd;
            Id=NextID++;
        }


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

        public int? Age
        {
            get
            {
                return DateTime.Now.Year - Birthday?.Year;
            }
        }

        public override string ToString()
        {
            return "Person " + Name + "(" + Id +"), " + Email + ", " + BirthdayString;
        }

        public virtual void DoSomeWork()
        {
            Console.WriteLine("You cannot give me orders");
        }
    }

    internal record Customer(string Name,double Purchases);

    internal record Customer2
    {
        private string name;
        public double Purchases { get; set; }

        public Customer2(string name,double p)
        {
            this.name = name;
            Purchases = p;
        }
    }
}
