using System;
using System.Collections.Generic;

namespace EntityAssignment1.Models
{
    public partial class Course
    {
        public int StudentId { get; set; }
        public string CourseTitle { get; set; } = null!;
        public int Matno { get; set; }
        public int CourseUnit { get; set; }
        public string Faculty { get; set; } = null!;
        public int CourseNo { get; set; }
        public DateTime RegDate { get; set; }

        public virtual Student MatnoNavigation { get; set; } = null!;
    }
}
