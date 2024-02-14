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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private List<Category> categories;

        public EfCategoryDal()
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
    }
}
