using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionOverriiding
{
    class Professor : Person
    {
        string subject;
        int experience;
        int booksPublished;

        public Professor() { }

        public Professor(string name, string subject, string departmentName, int totalExperience, int noOfBooksWritten)
            : base(name, departmentName)
        {
            this.subject = subject;
            this.experience = totalExperience;
            this.booksPublished = noOfBooksWritten;
        }

        public string Subject
        {
            set => this.subject = value;
            get => this.subject;
        }

        public int BooksPublished
        {
            set => this.booksPublished = value;
            get => this.booksPublished;
        }

        public int Experience
        {
            set => this.experience = value;
            get => this.experience;
        }
        /**
         *  public string PrintInfo()
        {
            string info = base.PrintInfo();
            return $"{info}, {experience}, {subject}, {booksPublished}";
        }
         */
        public override string PrintInfo()
        {
            string info = base.PrintInfo();
            return $"{info}, {experience}, {subject}, {booksPublished}";
        }
    }
}
