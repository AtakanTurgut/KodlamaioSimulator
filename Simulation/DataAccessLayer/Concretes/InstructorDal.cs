using DataAccessLayer.Abstracts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.ImageUrl = "AtakanTurgut";
            instructor1.Name = "Atakan";
            instructor1.Surname = "Turgut";
            instructor1.Description = "Açıklama Atakan";

            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 2;
            instructor2.ImageUrl = "FurkanUvenc";
            instructor2.Name = "Furkan";
            instructor2.Surname = "Üvenç";
            instructor2.Description = "Açıklama Furkan";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }

        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            instructors.Remove(entity);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return instructors.FirstOrDefault(c => c.InstructorId == id);
        }

        public void Update(Instructor entity)
        {
            Instructor instructorToUpdate = instructors.FirstOrDefault(c => c.InstructorId == entity.InstructorId);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.ImageUrl = entity.ImageUrl;
                instructorToUpdate.Name = entity.Name;
                instructorToUpdate.Surname = entity.Surname;
                instructorToUpdate.Description = entity.Description;
            }
        }
    }
}
