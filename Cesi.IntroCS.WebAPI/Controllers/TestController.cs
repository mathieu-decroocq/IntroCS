using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cesi.IntroCS.WebAPI.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { Test = "Hello world" });
        }

        [HttpGet]
        public IHttpActionResult Get2(int id)
        {
            if (id == 0)
            {
                return BadRequest("Erreur");
            }
            else
            {
                return Ok();
            }

        }
    }
}
