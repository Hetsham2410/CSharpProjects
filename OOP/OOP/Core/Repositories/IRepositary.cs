using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Repositories
{
    internal interface IRepositary<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        
    }
}
