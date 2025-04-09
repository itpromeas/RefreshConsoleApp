using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp.Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
