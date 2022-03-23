using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Questionbank
    {
        public Questionbank()
        {
            Answerbank = new HashSet<Answerbank>();
            Correctanswer = new HashSet<Correctanswer>();
        }

        public int QId { get; set; }
        public string QText { get; set; }
        public int? LevelId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Examcategory Category { get; set; }
        public virtual Difficultylevel Level { get; set; }
        public virtual ICollection<Answerbank> Answerbank { get; set; }
        public virtual ICollection<Correctanswer> Correctanswer { get; set; }
    }
}
