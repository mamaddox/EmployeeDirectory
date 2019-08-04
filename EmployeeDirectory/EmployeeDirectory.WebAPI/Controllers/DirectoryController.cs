using System.Web.Http;
using EmployeeDirectory.Directory;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.WebAPI.Controllers
{
    public class DirectoryController : BaseController
    {
        private readonly IDirectory<EmployeeEntity> directory
            = DirectorySingleton.Instance;
            
        [Route("api/Employees")]
        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            return Get(directory.GetAll);
        }

        [Route("api/Search")]
        [HttpPost]
        public IHttpActionResult GetEmployeesBySearchParameter([FromBody]SearchParameterEntity searchParameter)
        {
            return Post(() => directory.GetBySearchParameter(searchParameter));
        }
    }
}