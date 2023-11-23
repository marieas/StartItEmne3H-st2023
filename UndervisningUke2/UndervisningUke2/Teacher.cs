using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningUke2
{
    internal class Teacher
    {
        public string name;

        public Teacher(string navn)
        {
            name = navn;
        }

        public void Introduction()
        {
            Console.WriteLine("Hi im a teacher and my name is " + name);
        }
       public void GiveLecture()
        {
            Console.WriteLine($"{name} is holding a lecture");
        }
    }
}
