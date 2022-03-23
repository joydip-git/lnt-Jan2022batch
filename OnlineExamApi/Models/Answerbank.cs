using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Answerbank
    {
        public Answerbank()
        {
            Correctanswer = new HashSet<Correctanswer>();
        }

        public int AnsId { get; set; }
        public string AnsText { get; set; }
        public int? QId { get; set; }

        public virtual Questionbank Q { get; set; }
        public virtual ICollection<Correctanswer> Correctanswer { get; set; }
    }
}
