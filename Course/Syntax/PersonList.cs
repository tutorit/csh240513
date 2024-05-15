using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal class PersonList
    {
        List<Person> persons = new()
        {
            new Person("Aapo","aapo@veljekset.net",new DateOnly(1950,5,2)),
            new Person("Tuomas","tuomas@veljekset.net",new DateOnly(1930,5,2)),
            new Person("Simeoni","simeoni@veljekset.net",new DateOnly(1960,5,2)),
            new Person("Eero","eero@veljekset.net",new DateOnly(1970,5,2)),
            new Person("Lauri","lauri@veljekset.net",new DateOnly(1970,5,2)),
            new Person("Juhani","juhani@veljekset.net",new DateOnly(1910,5,2)),
            new Person("Timo","timo@veljekset.net",new DateOnly(1980,5,2)),
        };

        public void ShowAll(string title = "_____ALL_____")
        {
            Console.WriteLine(title);
            foreach (Person p in persons) Console.WriteLine(p);
        }

        public void PrintReverse()
        {
            Console.WriteLine("____PRINT_REVERSE____");
            for(int i=persons.Count-1;i>=0;i--) Console.WriteLine(persons[i]);
        }

        public void SortByName()
        {
            persons.Sort();
        }

        public void SortByAge()
        {
            persons.Sort((a, b) => a.Age.Value - b.Age.Value);
        }

        public Person this[string name]
        {
            get
            {
                return persons.Find(p => p.Name == name);
            }
        }

        public IEnumerable<Person> Reverse()
        {
            for(int i = persons.Count-1; i >= 0; i--)
            {
                yield return persons[i];
            }
        }

        public IEnumerable<Person> OrderByNameAgeGreaterThan(int age)
        {
            //return from Person p in persons where p.Age > age orderby p.Name select p;
            return persons
                .Where(p => p.Age > age)
                .OrderBy(p => p.Name);
        }

        public IEnumerable<(string Name, int Age)> Seniors()
        {
            return persons
                .Where(p => p.Age > 60)
                .OrderBy(p => p.Name)
                .Select(p => (p.Name, p.Age.Value));
        }
    }
}
