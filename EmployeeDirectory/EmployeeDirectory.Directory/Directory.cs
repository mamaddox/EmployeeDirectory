using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EmployeeDirectory.Data;
using EmployeeDirectory.Entities;
using Newtonsoft.Json;

namespace EmployeeDirectory.Directory
{
    public class Directory : IDirectory<EmployeeEntity>
    {
        private readonly List<EmployeeEntity> employees;

        public Directory() : this(DataLoader.GetEmployees())
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

        public IEnumerable<EmployeeEntity> Search(Tuple<string,string> searchParameter)
        {
            if (searchParameter == null)
                throw new ArgumentNullException();

            var field = searchParameter.Item1;
            var value = searchParameter.Item2;

            var results = new HashSet<EmployeeEntity>();

            foreach(var employee in employees)
            {
                foreach(var prop in typeof(EmployeeEntity).GetProperties())
                {
                    var jsonPropertyName = prop.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;
                    if (field != "" && jsonPropertyName != field)
                        continue;

                    if (prop.GetValue(employee) == null)
                        continue;

                    if (prop.GetValue(employee).ToString().Contains(value))
                        results.Add(employee);
                }
            }

            return results;
        }
    }
}