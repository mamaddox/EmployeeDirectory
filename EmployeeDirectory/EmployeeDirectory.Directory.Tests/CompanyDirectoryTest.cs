using System.Linq;
using EmployeeDirectory.Entities.Attributes;
using NUnit.Framework;

namespace EmployeeDirectory.Directory.Tests
{
    [TestFixture]
    public class CompanyDirectoryTest
    {
        private readonly IBaseDirectory<EmployeeEntity> companyDirectory
            = new CompanyDirectory();

        [Test]
        public void GetEmployees_ShouldReturn100Employees()
        {
            var employees = companyDirectory.GetAll().ToList();
            Assert.AreEqual(10, employees.Count);
        }
    }
}