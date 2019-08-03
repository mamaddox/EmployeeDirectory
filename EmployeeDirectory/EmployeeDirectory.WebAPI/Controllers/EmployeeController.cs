using System.Web.Http;
using EmployeeDirectory.Entities;

namespace EmployeeDirectory.WebAPI.Controllers
{
    public class EmployeeController : BaseController
    {
        [Route("api/Fields")]
        [HttpGet]
        public IHttpActionResult GetFields()
        {
            return Json(new AttributeGetter<EmployeeEntity>().Fields);
        }
    }
}