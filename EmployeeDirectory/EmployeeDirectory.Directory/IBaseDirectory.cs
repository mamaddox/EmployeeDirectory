using System.Collections.Generic;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.Directory
{
    public interface IBaseDirectory<TEntity>
        where TEntity : IEntity
    {
        IEnumerable<TEntity> GetAll();
        //IEnumerable<TEntity> Search(NameValueCollection searchParameters);
        //void Add(TEntity entity);
        //void Update(TEntity entity);
        //void Delete(int Id);
    }
}