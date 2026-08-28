using System;
using System.Collections.Generic;
using System.Text;

namespace C_basics02
{
    internal class Book
    {
        public string title { get; set; }
        public int pages { get; set; }
        override public string ToString()
        {
            return $"Book: {title}, Pages: {pages}";
        }
    }
}
