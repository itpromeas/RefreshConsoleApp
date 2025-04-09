using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp.Testability
{
    public class OrderProcessor

    {

        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)

        {

            _shippingCalculator = shippingCalculator;

        }



        public void Process(Order order)

        {

            if (order.IsShipped)
                throw new InvalidOperationException("This order is already shipped");


            order.Shipment = new Shipment

            {

                Cost = _shippingCalculator.CalculateShipping(order),

                ShippingDate = DateTime.Now.AddDays(1)

            };

        }



    }
}
