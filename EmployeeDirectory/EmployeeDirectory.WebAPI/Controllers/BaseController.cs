using System;
using System.Collections;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeDirectory.WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public abstract class BaseController : ApiController
    {
        public IHttpActionResult Get(object obj)
        {
            try
            {
                return Json(obj);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public IHttpActionResult Get(Func<IEnumerable> func)
        {
            try
            {
                return ExecuteFunctionAndReturnResult(func);
            }
            catch(Exception error)
            {
                throw error;
            }
        }

        public IHttpActionResult Post(Func<IEnumerable> func)
        {
            try
            {
                return ExecuteFunctionAndReturnResult(func);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        private IHttpActionResult ExecuteFunctionAndReturnResult(Func<IEnumerable> func)
        {
            return Json(func());
        }
    }
}