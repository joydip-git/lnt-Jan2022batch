using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Userexamrecord
    {
        public int ExamEntryId { get; set; }
        public string EmailId { get; set; }
        public int Score { get; set; }
        public int? LevelId { get; set; }

        public virtual Login Email { get; set; }
        public virtual Difficultylevel Level { get; set; }
    }
}
