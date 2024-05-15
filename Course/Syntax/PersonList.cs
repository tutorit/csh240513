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
    }
}
