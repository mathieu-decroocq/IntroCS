using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cesi.IntroCS.CoreDataAccess;
using Cesi.IntroCS.CoreDataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/blog")]
    public class BlogController : Controller
    {
        private readonly IDAL<Blog> blogDal;
        public BlogController(IDAL<Blog> blogDal)
        {
            this.blogDal = blogDal;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return this.blogDal.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return this.blogDal.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
