using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeDirectory.Entities;
using NUnit.Framework;

namespace EmployeeDirectory.Directory.Tests
{
    [TestFixture]
    public class DirectoryTest
    {
        private Directory directory;

        [SetUp]
        public void Intialize()
        {
            InitializeDirectory();
        }

        [Test]
        public void GetAll_ShouldReturn50Employees()
        {
            var employees = new Directory().GetAll().ToList();
            Assert.AreEqual(50, employees.Count);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_GivenNull_ShouldThrowArgumentNullException()
        {
            directory.Add(null);
        }

        [Test]
        public void Add_GivenEmployee_ShouldAddEmployeeToDirectory()
        {
            var employees = directory.GetAll().ToList();
            Assert.AreEqual(4, employees.Count);

            var newEmployee = new EmployeeEntity
            {
                FirstName = "Test",
                LastName = "Test",
            };
            directory.Add(newEmployee);
            employees = directory.GetAll().ToList();
            var addedEmployee = employees.Last();

            Assert.AreEqual(5, employees.Count);
            Assert.AreSame(newEmployee.FirstName, addedEmployee.FirstName);
            Assert.AreSame(newEmployee.LastName, addedEmployee.LastName);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Search_GivenNull_ShouldThrowArgumentNullException()
        {
            directory.Search(null);
        }

        [Test]
        public void Search_GivenEntityWithAllFields_ShouldReturnFilteredResults()
        {
            var searchParameter = new SearchParameterEntity("", "Tes");

            var searchResults = directory.Search(searchParameter).ToList();

            Assert.AreEqual(4, searchResults.Count);
        }

        [Test]
        public void Search_GivenEntityWithSpecificFields_ShouldReturnFilteredResults()
        {
            var searchParameter = new SearchParameterEntity("Department", "Test");

            var searchResults = directory.Search(searchParameter).ToList();

            Assert.AreEqual(3, searchResults.Count);
            Assert.True(searchResults.All(result => result.Department == "Test"));
        }

        private void InitializeDirectory()
        {
            var testEmployees = new List<EmployeeEntity>
            {
                new EmployeeEntity
                {
                    Id = 1,
                    FirstName = "First1",
                    LastName = "Last1",
                    Title = "Title1",
                    Department = "Test"
                },

                new EmployeeEntity
                {
                    Id = 2,
                    FirstName = "First2",
                    LastName = "Last2",
                    Title = "Title2",
                    Department = "Test"
                },

                new EmployeeEntity
                {
                    Id = 3,
                    FirstName = "First3",
                    LastName = "Last3",
                    Title = "Title3",
                    Department = "Test"
                },

                new EmployeeEntity
                {
                    Id = 4,
                    FirstName = "First3",
                    LastName = "Last3",
                    Title = "Test",
                    Department = "Department"
                }
            };

            directory = new Directory(testEmployees);
        }
    }
}