using DataAccessLayer.Abstracts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.Title = "Programlama";

            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.Title = "Finans & Muhasebe";

            Category category3 = new Category();
            category3.CategoryId = 3;
            category3.Title = "Kişisel Gelişim";

            categories = new List<Category> { category1, category2, category3 };
        }

        public void Add(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            categories.Remove(entity);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Update(Category entity)
        {
            Category categoryToUpdate = categories.FirstOrDefault(c => c.CategoryId == entity.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Title = entity.Title;
            }
        }
    }
}
