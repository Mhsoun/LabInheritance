using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomList
{
    class StackOfStrings
    {
        private List<string> data = new List<string>();

        public void Push(string stringToPush)
        {
            data.Add(stringToPush);

        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }
        public string Pop(string stringIn)
        {
            data.Add(stringIn);
            var popOut = data.Count - 1;
            var toRetrun = data[popOut];
            data.RemoveAt(popOut);
            return toRetrun;
        }
        public string Peek()
        {
            return data[data.Count - 1];
        }
    }
}
