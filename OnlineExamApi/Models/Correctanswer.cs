using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Correctanswer
    {
        public int CorrectAnsId { get; set; }
        public int? QId { get; set; }
        public int? AnsId { get; set; }

        public virtual Answerbank Ans { get; set; }
        public virtual Questionbank Q { get; set; }
    }
}
