using System;
using Zadania.doc3Class;

namespace Zadania
{
    public class TooLongEx: Exception

    {
        public Global Gl { get; set; }
        public ZadGlobal ZGl { get; set; }

        public TooLongEx()
        {
        }

        public TooLongEx(Global g, string message): base(message)
        {
            Gl = g;
        }
        public TooLongEx(ZadGlobal g, string message): base(message)
        {
            ZGl = g;
        }
    }
}