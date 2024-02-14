using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Description { get; set; }

        public List<Course> Courses { get; set; }
    }
}
