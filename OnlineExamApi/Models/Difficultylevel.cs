using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineExamSystemApp.Models
{
    public partial class Difficultylevel
    {
        public Difficultylevel()
        {
            Questionbank = new HashSet<Questionbank>();
            Userexamrecord = new HashSet<Userexamrecord>();
        }

        public int LevelId { get; set; }
        public int LevelName { get; set; }

        public virtual ICollection<Questionbank> Questionbank { get; set; }
        public virtual ICollection<Userexamrecord> Userexamrecord { get; set; }
    }
}
