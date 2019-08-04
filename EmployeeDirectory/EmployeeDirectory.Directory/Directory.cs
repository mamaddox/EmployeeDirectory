using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EmployeeDirectory.Entities;
using Newtonsoft.Json;

namespace EmployeeDirectory.Directory
{
    public class Directory : IDirectory<EmployeeEntity>
    {
        private readonly List<EmployeeEntity> employees;

        protected Directory()
        {
        }

        internal Directory(IEnumerable<EmployeeEntity> employees)
        {
            this.employees = employees.ToList();
        }

        public IEnumerable<EmployeeEntity> GetAll()
        {
            return employees;
        }

        public void Add(EmployeeEntity employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            employee.Id = employees.Count + 1;
            employees.Add(employee);
        }

        public IEnumerable<EmployeeEntity> GetBySearchParameter(ISearchParameterEntity searchParameter)
        {
            if (searchParameter == null)
                throw new ArgumentNullException();

            var field = searchParameter.Field;
            var value = searchParameter.Value.ToUpper();

            var results = new HashSet<EmployeeEntity>();

            foreach(var employee in employees)
            {
                foreach(var prop in typeof(EmployeeEntity).GetProperties())
                {
                    var jsonPropertyName = prop.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;
                    if (field != "" && jsonPropertyName != field)
                        continue;

                    var propValue = prop.GetValue(employee);

                    if (propValue == null)
                        continue;

                    if (propValue.ToString().ToUpper().Contains(value))
                        results.Add(employee);
                }
            }

            return results;
        }
    }
}