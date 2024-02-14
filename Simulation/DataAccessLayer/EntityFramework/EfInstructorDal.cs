using DataAccessLayer.Abstracts;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfInstructorDal : GenericRepository<Instructor>, IInstructorDal
    {
        private List<Instructor> instructors;

        public EfInstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.ImageUrl = "AtakanTurgut";
            instructor1.Name = "Atakan";
            instructor1.Surname = "Turgut";
            instructor1.Description = "Açıklama Atakan";

            Instructor instructor2 = new Instructor();
            instructor1.InstructorId = 2;
            instructor2.ImageUrl = "FurkanUvenc";
            instructor2.Name = "Furkan";
            instructor2.Surname = "Üvenç";
            instructor2.Description = "Açıklama Furkan";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }
    }
}
