using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningUke2
{
    internal class Student
    {
        //variabler

        //Ting som beskriver klassen/objektet 
        //Ting objektet kan inneholde

        public string name;
        int age;
        bool isIntern;


        public Student(string navn,int alder)
        {
            name = navn;
            age = alder;
        }

        //(Funksjoner)
        //Ting objektet kan gjøre 
        public void Introduction()
        {
            Console.WriteLine($"{name}, {age} yrs old");
        }

        public void WatchLecture()
        {
            Console.WriteLine($"{name} is watching a lecture");
        }

    }
}
