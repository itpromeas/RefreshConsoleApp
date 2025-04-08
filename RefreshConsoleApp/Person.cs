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
        public DateTime _birthdate { get; set; }

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
