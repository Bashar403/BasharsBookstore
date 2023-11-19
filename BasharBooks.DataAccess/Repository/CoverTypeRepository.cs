using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasharsBookstore.DataAccess.Data;
using BasharsBookstore.Models;
using BasharBooks.DataAccess.Repository.IRepository;

namespace BasharBooks.DataAccess.Repository
{
    public class CoverTypeRepository : ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Add(CoverType coverType)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CoverType> GetAll()
        {
            throw new NotImplementedException();
        }

        public CoverType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
