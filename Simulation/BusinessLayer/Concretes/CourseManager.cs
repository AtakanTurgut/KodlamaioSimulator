﻿using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void TAdd(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void TDelete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public List<Course> TGetAll()
        {
            return _courseDal.GetAll();
        }

        public Course TGetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void TUpdate(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
