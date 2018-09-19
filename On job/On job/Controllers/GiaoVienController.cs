using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onjob.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Onjob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaoVienController : ControllerBase
    {
        private readonly OnJobContext _context;
        public GiaoVienController(OnJobContext context)
        {
            _context = context;
        }
        // GET: api/MonHoc
        [HttpGet]
        public ActionResult<List<GiaoVien>> Get()
        {
            return _context.GiaoViens.ToList();
        }

        // GET api/<controller>/5
       /* [HttpGet("{id}")]
        public ActionResult<MonHoc> Get(long id)
        {
            var item = _context.MonHocs.Find(id);
            if (item == null)
            {
                return NoContent();
            }
            return item;
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Create(MonHoc monHoc)
        {
            _context.MonHocs.Add(monHoc);
            _context.SaveChanges();
            return CreatedAtRoute("Get", new { id = monHoc.ID }, monHoc);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Update(MonHoc monHoc, long id)
        {
            var mh = _context.MonHocs.Find(id);
            if (mh == null)
            {
                return NoContent();
            }
            mh.Ma = monHoc.Ma;
            mh.Ten = monHoc.Ten;
            mh.HienThi = monHoc.HienThi;
            mh.NgayCN = DateTime.Now;
            mh.NguoiCN = monHoc.NguoiCN;
            mh.Khac = monHoc.Khac;

            _context.MonHocs.Update(mh);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var mh = _context.MonHocs.Find(id);
            if (mh == null)
            {
                return NotFound();
            }
            _context.MonHocs.Remove(mh);
            _context.SaveChanges();
            return NoContent();
        }

        //GET api/search
        [HttpGet("search/{searchTest}", Name = "Search")]
        public ActionResult<List<MonHoc>> Search(string searchText)
        {
            return _context.MonHocs.Where(x => x.Ten.Contains(searchText)).ToList();
        }*/
    }
}
