using DataAccessLayer.Abstracts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes
{
    public class CourseDal : ICourseDal
    {
        private List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.ImageUrl = "csbasic";
            course1.Title = "C# Temel";
            course1.ProgressBar = 0;
            course1.CategoryId = 1;
            course1.InstructorId = 1;

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.ImageUrl = "javabasic";
            course2.Title = "Java Temel";
            course2.ProgressBar = 0;
            course2.CategoryId = 1;
            course2.InstructorId = 2;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.ImageUrl = "progress";
            course3.Title = "Gelecek Öngörülür Mü?";
            course3.ProgressBar = 0;
            course3.CategoryId = 3;
            course3.InstructorId = 1;

            Course course4 = new Course();
            course4.CourseId = 4;
            course4.ImageUrl = "moneydecrease";
            course4.Title = "Paraya Değer Kat";
            course4.ProgressBar = 0;
            course4.CategoryId = 2;
            course4.InstructorId = 2;

            courses = new List<Course> { course1, course2, course3, course4 };
        }

        public void Add(Course entity)
        {
            courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            courses.Remove(entity);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.CourseId == id);
        }

        public void Update(Course entity)
        {
            Course courseToUpdate = courses.FirstOrDefault(c => c.CourseId == entity.CourseId);
            if (courseToUpdate != null)
            {
                courseToUpdate.ImageUrl = entity.ImageUrl;
                courseToUpdate.Title = entity.Title;
                courseToUpdate.ProgressBar = entity.ProgressBar;

                courseToUpdate.InstructorId = entity.InstructorId;
                courseToUpdate.CategoryId = entity.CategoryId;
            }
        }
    }
}
