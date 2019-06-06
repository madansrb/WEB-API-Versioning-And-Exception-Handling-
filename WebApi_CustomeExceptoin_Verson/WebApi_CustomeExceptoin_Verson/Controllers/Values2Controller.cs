using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;
namespace WebApi_CustomeExceptoin_Verson.Controllers
{
    public class Values2Controller : ApiController
    {
        [ApiVersion("2.0")]
        [Route("api/values")]
        public IEnumerable<string> Get()
        {

            return new string[] { "version 2.0", "version 2.0" };
        }
    }
}
