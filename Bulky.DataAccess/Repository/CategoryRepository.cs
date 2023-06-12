using System;
using System.Linq.Expressions;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _db;
        

        public CategoryRepository(ApplicationDBContext db): base(db)
        {
            _db = db;
           
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}

