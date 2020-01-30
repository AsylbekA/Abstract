using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Client :Person
    {
        public decimal summ_card { get; set; }
        public Client(string name,string surname,decimal summ)
            : base(name, surname)
        {
            summ_card = summ;
        }

        public override void Display()
        {
            
            Console.WriteLine($"Client: {firstname} {lastname} the remaining amount: {summ_card} $ ");
        }
    }
}
