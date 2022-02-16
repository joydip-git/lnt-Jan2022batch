using System;
using System.Collections.Generic;
using System.Text;

namespace CompleteApp
{
    class Professor : Person
    {
        int booksPublished;

        public Professor() { }
        public Professor(string name, int books)
            : base(name)
        {
            this.booksPublished = books;
        }

        public int BooksPublished { get => booksPublished; set => booksPublished = value; }

        public override bool IsOutstanding()
        {
            return booksPublished > 5 ? true : false;
        }
        public override string PrintInfo()
        {
            return $"{base.PrintInfo()}, {booksPublished}";
        }
    }
}
