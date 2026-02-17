using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue2026
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nAge: {Age}";
        }       
    }
}
