using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp
{
    public class CustomerJustToKnow
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }

        public CustomerJustToKnow()
        {
            this.Orders = new List<Order>(); // make sure a list is always initialize
        }

        public CustomerJustToKnow(int id) : this() // :this() means that before calling the constructor(int id) it will first call the empty constructor
        {
            this.Id = id;
        }

        public CustomerJustToKnow(int id, string name) : this(id) // one can also do this similarly. But it is not a good practice
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
