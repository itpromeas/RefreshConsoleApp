using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            // params helps not to initialize the numbers all the time
            // one can do
            // calculator.Add(new int[]{1,2,3,4,5})
            // calculator.Add(1,2,3,4,5)
            var sum = 0;
            foreach (var number in numbers) 
            { 
                sum += number;
            }
            return sum;
        }

        public void MyMethod1(ref int myValue) 
        {
            myValue = 0;
            // ref means myValue will also change outside MyMethod1.
        }

        public void MyMethod2(out int myValue)
        {
            myValue = 0;
            // out means myValue will also change outside MyMethod2.
        }
    }
}
