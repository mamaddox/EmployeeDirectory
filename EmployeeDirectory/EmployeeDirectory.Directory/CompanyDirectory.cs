using System.Collections.Generic;
using EmployeeDirectory.Data;
using EmployeeDirectory.Entities.Attributes;

namespace EmployeeDirectory.Directory
{
    public class CompanyDirectory : IBaseDirectory<EmployeeEntity>
    {
        public IEnumerable<EmployeeEntity> GetAll()
        {
            return DataLoader.GetEmployees();
        }
    }
}