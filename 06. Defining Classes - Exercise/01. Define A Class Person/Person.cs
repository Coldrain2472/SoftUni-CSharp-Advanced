using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Runtime;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "Peter";
            Age = 20;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
