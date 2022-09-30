using System;
using System.Collections.Generic;

namespace Paycomputing1193
{
    public partial class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public double Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public string Administrator { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }
    }
}
