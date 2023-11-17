using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Core Katmanı diğer katmanları referans almaz

    //Generic Constraint
    //class : that means it can be only reference type (so not only class)
    //IEntity: It can be IEntity or an object that implements IEntity
    //And it should be a thing that can be newed
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
