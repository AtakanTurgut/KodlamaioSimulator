using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public int ProgressBar { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
