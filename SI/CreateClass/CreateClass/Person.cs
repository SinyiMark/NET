using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    abstract class Person
    {
        public string name;
        public DateTime birthDate;
        public Genders gender;
        public enum Genders {
            Male,
            Female 
            }

        public Person(string name, DateTime birthDate,Genders genders)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = genders;
        }

        public override string ToString()
        {
            string data = $"Name:{name} , BirthDay: {birthDate.ToString()}, Gender: {gender.ToString()}";
            return data;
        }
    }
}
