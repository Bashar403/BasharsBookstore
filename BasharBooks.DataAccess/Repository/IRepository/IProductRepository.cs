using BasharBooks.Models;
using System;
using System.Collections.Generic;

namespace BasharBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Remove(int id);
        void Save();
    }
}
