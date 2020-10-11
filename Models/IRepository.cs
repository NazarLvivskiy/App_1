using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

         List<TEntity> GetAll();

         TEntity Get(int id);

         void Update(TEntity entity);

         void Delete(int id);
    }
}
