using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    public class Stack
    {
        //initialize list of objects
        private readonly List<object> _stack = new List<object>();

        public void Push(object stackIndex)
        {
            if (stackIndex != null)
            {
                _stack.Add(stackIndex);
            }
            else
                throw new InvalidOperationException("You can't store a null reference!");
        }

        public object Pop()
        {
            var stackReturn = _stack.Count - 1;
            if (_stack != null)
            {
                var poppedIndex = _stack[stackReturn];
                _stack.RemoveAt(stackReturn);
                return poppedIndex;
            }
            else
                throw new InvalidOperationException("You can't remove a null reference!");
        }

        public void Clear()
        {
            //clear list
            _stack.Clear();
        }
    }
}
