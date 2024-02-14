using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Title { get; set; }

        public List<Course> Courses { get; set; }
    }
}
