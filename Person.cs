using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1CheatSheet
{
    class Person
    {
        string name;
        int age;
        string city;
        
        // Konstruktor för klassen, tar in 3 parmetrar
        public Person(string name, int age, string city)
        {
            // nyckelordet this pekar på klassens instansvariabel
            this.name = name;
            this.age = age;
            this.city = city;
        }
    }
}
