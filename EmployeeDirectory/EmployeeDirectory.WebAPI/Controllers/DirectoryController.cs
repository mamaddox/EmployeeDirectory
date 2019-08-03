using System.Web.Http;
using EmployeeDirectory.Directory;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.WebAPI.Controllers
{
    public class DirectoryController : BaseController
    {
        private readonly IDirectory<EmployeeEntity> companyDirectory
            = new Directory.Directory();
            
        [Route("api/Employees")]
        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            return Json(companyDirectory.GetAll());
        }
    }
}