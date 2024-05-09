using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Repositories
{
    internal class DeletableRepository<T> : Repository<T> ,IDeletableRepository<T> where T : Entity
    {
        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }
    }
}
