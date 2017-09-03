using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XH.BudgetSystem.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            using (BudgetSystemContext db =new BudgetSystemContext())
            {
                return Ok(db.Projects.ToList());
            }
        }
    }
}
