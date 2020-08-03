using System;
using System.Collections.Generic;
using System.Text;

namespace lsl.Exceptions
{
    class CompilationException : Exception
    {
        public CompilationException(string Msg) : base(Msg)
        {

        }
    }
}
