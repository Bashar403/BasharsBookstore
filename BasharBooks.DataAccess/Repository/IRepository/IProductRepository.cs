using BasharBooks.Models;
using System;
using System.Collections.Generic;

namespace BasharBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
