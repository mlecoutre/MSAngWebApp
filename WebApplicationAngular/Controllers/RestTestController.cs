using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/RestTest")]
    public class RestTestController : Controller
    {

        // GET: api/Editors/5
        [HttpGet("{id}")]
        public String DoGet(int id)
        {

            return "hello world";

        }
    }
}