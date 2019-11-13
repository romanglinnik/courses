using System;
using System.Collections.Generic;
using System.Text;

namespace ChessProj
{
    class MyOutOfRangeException : Exception
    {
        public MyOutOfRangeException(string message) : base(message)
        {

        }
    }
}

