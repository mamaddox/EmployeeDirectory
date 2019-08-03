using System.Web.Http;
using EmployeeDirectory.Directory;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.WebAPI.Controllers
{
    public class DirectoryController : BaseController
    {
        private readonly IBaseDirectory<EmployeeEntity> companyDirectory
            = new CompanyDirectory();
            
        [Route("api/Employees")]
        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            return Json(companyDirectory.GetAll());
        }
    }
}