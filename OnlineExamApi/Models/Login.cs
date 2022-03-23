using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Login
    {
        public Login()
        {
            Registration = new HashSet<Registration>();
            Userexamrecord = new HashSet<Userexamrecord>();
        }

        public string EmailId { get; set; }
        public string Password { get; set; }
        public int? TypeId { get; set; }

        public virtual Usertype Type { get; set; }
        public virtual ICollection<Registration> Registration { get; set; }
        public virtual ICollection<Userexamrecord> Userexamrecord { get; set; }
    }
}
