using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp
{
    public class Person
    {
        private string? _name;
        public DateTime Birthdate { get; private set; } // private set; means that _birthdate can only be set once


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public Person()
        {
            
        }

        /*
        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }*/

        /*public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }*/

        public int Age 
        {
            get 
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;
                return years;
            }
        }




        public void Introduction(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, _name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person._name = str;

            return person;
        }
    }
}
