using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onjob.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Onjob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeMucController : ControllerBase
    {
        private readonly OnJobContext _context;
        public DeMucController(OnJobContext context) {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult<List<DeMuc>> Get()
        {
            return _context.DeMucs.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
