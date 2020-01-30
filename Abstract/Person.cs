using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
   abstract class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Person(string name,string surname)
        {
            firstname = name;
            lastname = surname;
        }

        public abstract void Display();
      
    }
}
