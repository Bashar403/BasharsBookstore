using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasharBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IDisposable
    {
        IEnumerable<CoverType> GetAll();   
        CoverType GetById(int id);          
        void Add(CoverType coverType);      
        void Update(CoverType coverType);   
        void Remove(int id);                
        void Save();
    }
}
