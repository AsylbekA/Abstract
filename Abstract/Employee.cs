using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Employee :Person
    {
        public string position { get; set; }
        public Employee(string name, string surname,string pos)
            : base(name, surname)
        {
            position = pos;
        }
        public override void Display()
        {
            Console.WriteLine($"Employee: {firstname}  {lastname}  position is  {position}");
        }
    }
}
