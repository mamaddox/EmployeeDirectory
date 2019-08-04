using System.Collections.Generic;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.Directory
{
    public interface IDirectory<TEntity>
        where TEntity : IEntity
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetBySearchParameter(ISearchParameterEntity searchParameter);
        void Add(TEntity entity);
    }
}