using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Asulbek","Anarbay","Gen Director");
            Client cl = new Client("Baxa","Serikyli",67000);
            Person per = new Client("Nur","Pazilkhan",87000);
            Person per2 = new Employee("Ulan","Kenes","Programmer");

            Figure mo = new Rectangle(5,7);
            mo.Perimetr();
        

       
            emp.Display();
            per.Display();
            per2.Display();
            cl.Display();
            Console.ReadKey();
        }
    }
}
