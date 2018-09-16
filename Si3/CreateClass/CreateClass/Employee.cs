using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person,ICloneable
    {
        public Room MyRoom { get; set; }
        public Employee(string name, DateTime birthDate, Genders genders,int salary,string profession) : base(name, birthDate, genders)
        {
            MyRoom = new Room(1);
            this.salary = salary;
            this.profession = profession;
        }

        public Employee()
        {
        }

        public int salary { get; set; }
        public string profession { get; set; }
        
        public override string ToString()
        {
            string data = $"Name: {name} , BirthDay: {birthDate.ToShortDateString()}, Gender: {gender},  Salary: {salary}, Profession: {profession}, Room: {MyRoom.roomId}\n";
            return data;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.MyRoom = new Room(3);
            return newEmployee;
        }
    }

}
