using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ExpensesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "expense1", "expense2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "expense";
        }
    }
}
