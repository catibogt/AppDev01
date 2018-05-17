using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 66;
            Employee e1;
            e1 = new Employee();
            e1.name = "Sue"; // upma
            e1.age = 25;

            Employee e2;
            e2 = new Employee();
            e2.name = "Joe";
            e2.age = 40;


            Console.WriteLine(e1.name);
            Console.WriteLine(e1.age);

            Console.WriteLine("===============");

            Console.WriteLine(e2.name);
            Console.WriteLine(e2.age);

            Console.ReadLine();





        }
    }
}
