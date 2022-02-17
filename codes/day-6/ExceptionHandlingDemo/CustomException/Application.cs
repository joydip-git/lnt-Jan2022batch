using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    class Application
    {
        string applicantName;
        DateTime dateOfBirth;
        int age;

        public Application() { }

        public Application(string name, DateTime dob)
        {
            this.applicantName = name;
            this.dateOfBirth = dob;
            this.Age = this.CalculateAge();
        }

        public string ApplicantName { get => applicantName; set => applicantName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    AgeLessThanEighteenException ex = new AgeLessThanEighteenException("Age is less than 18..can't issue DL");
                    throw ex;
                }
                else
                    age = value;
            }
            get => age;
        }

        private int CalculateAge()
        {
            DateTime current = DateTime.Now;
            //int difference = current.Year - dateOfBirth.Year;
            TimeSpan span = current.Subtract(dateOfBirth);
            int difference = (int)(span.Days / 365);
            return difference;
        }
    }
}
