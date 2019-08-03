using System;
using System.Collections.Generic;
using System.Web.Http;
using EmployeeDirectory.Directory;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.WebAPI.Controllers
{
    public class DirectoryController : BaseController
    {
        private readonly IDirectory<EmployeeEntity> directory
            = new Directory.Directory();
            
        [Route("api/Employees")]
        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            return Json(directory.GetAll());
        }

        [Route("api/Search")]
        [HttpPost]
        public IHttpActionResult GetEmployeesBySearchParameter([FromBody]SearchParameterEntity searchParameter)
        {
            return Json(directory.Search(searchParameter));
        }

        [Route("api/AddEmployee")]
        [HttpPost]
        public IHttpActionResult AddNewEmployee([FromBody]EmployeeEntity employee)
        {
            directory.Add(employee);
            return Ok();
        }
    }
}