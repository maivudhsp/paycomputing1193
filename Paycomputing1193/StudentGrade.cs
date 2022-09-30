using System;
using System.Collections.Generic;

namespace Paycomputing1193
{
    public partial class StudentGrade
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int PersonId { get; set; }
        public decimal Grade { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
    }
}
