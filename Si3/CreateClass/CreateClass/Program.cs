using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Laci = new Employee("laci", DateTime.Parse("2008-05-05"),Person.Genders.Male,1000,"anyád");
            Laci.Serialize("asdfa");
            Employee LaciClone = (Employee)Laci.Clone();
            LaciClone.MyRoom.roomId = 2;
            Console.Write(Laci.ToString());
            Console.Write(LaciClone.ToString());

        }
    }
}
