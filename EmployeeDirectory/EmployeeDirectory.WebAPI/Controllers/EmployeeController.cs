using System.Web.Http;
using EmployeeDirectory.Entities.Attributes;

namespace EmployeeDirectory.WebAPI.Controllers
{
    public class EmployeeController : BaseController
    {
        [Route("api/EmployeeAttributes")]
        [HttpGet]
        public IHttpActionResult GetEmployeeEntityAttributes()
        {
            return Json(new AttributeGetter<EmployeeEntity>());
        }
    }
}