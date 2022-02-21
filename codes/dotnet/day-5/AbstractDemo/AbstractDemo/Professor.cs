using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class Professor : Person
    {
        int bookspublished;
        public Professor()
        {
        }
        public Professor(string name, int books)
            : base(name)
        {
            this.bookspublished = books;
        }

        public int Bookspublished { get => bookspublished; set => bookspublished = value; }

        public override bool IsOutstanding()
        {
            if (bookspublished > 5)
                return true;
            else
                return false;
        }
    }
}
