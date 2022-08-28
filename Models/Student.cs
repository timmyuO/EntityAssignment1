using System;
using System.Collections.Generic;

namespace EntityAssignment1.Models
{
    public partial class Student
    {
        public string Name { get; set; } = null!;
        public int MatNo { get; set; }
        public string Department { get; set; } = null!;
        public int Year { get; set; }

        public virtual Course Course { get; set; } = null!;
    }
}
