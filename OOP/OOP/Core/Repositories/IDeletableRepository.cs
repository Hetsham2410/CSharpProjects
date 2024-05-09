using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Repositories
{
    internal interface IDeletableRepository<T> where T : Entity
    {
        void Delete(T entity);
    }
}
