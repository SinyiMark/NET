using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace CreateClass
{
    public abstract class Person
    {
        public string name;
        public int age;
        public DateTime birthDate;
        public Genders gender;
        public enum Genders {
            Male,
            Female 
            }

        public Person(string name, DateTime birthDate,Genders genders)
        {
            var today = DateTime.Today;
            age = today.Year - birthDate.Year;
            this.name = name;
            this.birthDate = birthDate;
            this.gender = genders;
        }

        protected Person()
        {
        }

        public override string ToString()
        {
            string data = $"Name:{name} , BirthDay: {birthDate.ToString()}, Gender: {gender.ToString()}";
            return data;
        }
        public void Serialize(string output)
        {
            if (!File.Exists(@"G:\CodeCool\NET\Si3\CreateClass/asd.txt"))
            {
                File.Create(@"G:\CodeCool\NET\Si3\CreateClass/asd.txt");
            }
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, this);
            }
            // Create file to save the data
            // Create and use a BinaryFormatter object to perform the serialization
            // Close the file


        }
    }
}
