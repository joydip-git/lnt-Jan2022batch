using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Registration
    {
        public int RegId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public DateTime Dob { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Qualification { get; set; }
        public DateTime CompletionYr { get; set; }

        public virtual Login Email { get; set; }
    }
}
