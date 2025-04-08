using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp
{
    public class Customer
    {
        private int Id { get; set; }
        private string Name { get; set; }

        private readonly List<Order> Orders = new List<Order>();


        public Customer(int id)
        {
           this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        public List<Order> GetOrders()
        {
            return Orders;
        }

        public void Promote()
        {
             
        }
    }
}
