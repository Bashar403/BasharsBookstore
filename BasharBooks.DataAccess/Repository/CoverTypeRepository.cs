﻿using System;
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
            _db.CoverTypes.Add(coverType);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<CoverType> GetAll()
        {
            return _db.CoverTypes.ToList();
        }

        public CoverType GetById(int id)
        {
            return _db.CoverTypes.Find(id);
        }

        public void Remove(int id)
        {
            var coverType = _db.CoverTypes.Find(id);
            if (coverType != null)
                _db.CoverTypes.Remove(coverType);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CoverType coverType)
        {
            _db.Dispose();
        }
    }
}
