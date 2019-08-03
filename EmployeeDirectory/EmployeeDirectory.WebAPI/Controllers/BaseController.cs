using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeDirectory.WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public abstract class BaseController : ApiController
    {
        public IHttpActionResult Get(Action func)
        {
            try
            {
                return ExecuteActionAndReturnResult(func);
            }
            catch(Exception error)
            {
                throw error;
            }
        }

        private IHttpActionResult ExecuteActionAndReturnResult(Action func)
        {
            func();
            return Ok();
        }
    }
}