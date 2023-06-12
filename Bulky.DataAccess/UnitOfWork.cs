using System;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Data;
namespace Bulky.DataAccess
{
	public class UnitOfWork: IUnitOfWork
	{
        private ApplicationDBContext _db;
        public UnitOfWork(ApplicationDBContext db)
		{
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

