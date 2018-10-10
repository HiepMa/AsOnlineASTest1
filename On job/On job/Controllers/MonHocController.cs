using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onjob.Models;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Onjob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonhocController : ControllerBase
    {
        private readonly OnJobContext _context;
        public MonhocController(OnJobContext context)
        {
            _context = context;
        }
        // GET: api/MonHoc
        [HttpGet]
        public ActionResult<List<MonHoc>> Get()
        {
            return _context.MonHocs.Where(x=>x.Xoa==false).ToList();
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<MonHoc> Get(long id)
        {
            var item = _context.MonHocs.Find(id);
            if(item == null)
            {
                return NoContent();
            }
            return item;
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult<MonHoc> Create(MonHoc monHoc)
        {
            string a = DateTime.Now.ToString("yyyyMMddhh:mm:ss");
            string fag = a.Replace(" ", "");
            string b = a.Replace("/", "");
            string c = b.Replace(":", "");
            long kq = long.Parse(c);
            monHoc.ID= kq;
            monHoc.Xoa = false;
            monHoc.HienThi = true;
            monHoc.NgayTao = DateTime.Now;
            monHoc.NgayCN = monHoc.NgayTao;
            monHoc.NguoiCN = monHoc.NguoiTao;
            //Kiem tra du lieu dau vao
            if (monHoc.Ma.Length > 30) return StatusCode(400,"Mã sai độ dài. Mã chỉ có 30 kí tự");
            if (monHoc.Ten.Length > 100) return StatusCode(400, "Tên sai độ dài. Tên chỉ có 100 kí tự");
            if (monHoc.Khac.Length > 250) monHoc.Khac = monHoc.Khac.Remove(250);

            _context.MonHocs.Add(monHoc);
            _context.SaveChanges();
            return monHoc;
        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Update(MonHoc monHoc, long id)
        {
            var mh = _context.MonHocs.Find(id);
            if(mh == null)
            {
                return NoContent();
            }
            mh.Ma = monHoc.Ma;
            mh.Ten = monHoc.Ten;
            mh.HienThi = monHoc.HienThi;
            mh.NgayCN = DateTime.Now;
            mh.NguoiCN = monHoc.NguoiCN;
            mh.Khac = monHoc.Khac;
            //Kiem tra du lieu dau vao
            if (monHoc.Ma.Length > 30) monHoc.Ma = monHoc.Ma.Remove(30);
            if (monHoc.Ten.Length > 100) monHoc.Ten = monHoc.Ten.Remove(100);
            if (monHoc.Khac.Length > 250) monHoc.Khac = monHoc.Khac.Remove(250);
            _context.MonHocs.Update(mh);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var mh = _context.MonHocs.Find(id);
            if(mh == null)
            {
                return NotFound();
            }
            mh.Xoa = true;
            _context.MonHocs.Update(mh);
            _context.SaveChanges();
            return NoContent();
        }

        //GET api/search
        [HttpGet("search/{searchTest}",Name ="Search")]
        public ActionResult<List<MonHoc>> Search(string searchText)
        {
            return _context.MonHocs.Where(x => x.Ten.Contains(searchText)).ToList();
        }

    }
}
