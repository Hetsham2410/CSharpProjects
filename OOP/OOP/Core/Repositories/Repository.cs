using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Repositories
{
    internal class Repository<T>: IRepositary<T> where T : Entity
    {
        protected List<T> _entities = new();
        public IEnumerable<T> GetAll()
        {
            return _entities.AsReadOnly();
        }
        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }
         public void Add(T entity)
        {
            entity.Id = _entities.Count + 1;
            _entities.Add(entity);
        }

    }
}
