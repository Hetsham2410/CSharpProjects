using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Repositories
{
    internal class UpdatableRepository<T> : Repository<T>, IUpdatableRepository<T> where T : Entity
    {
        public void Update(T entity)
        {
            var originalEntity = GetById(entity.Id);
            // TODO: Map entity to originalEntity to copy new data
        }
   

    }
}
