using AppData.IRepositories;
using AppData.Models;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MausacController : ControllerBase
    {
        private IAllRepositories<MauSac> irepos;
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context context = 
            new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public MausacController()
        {
            AllRepositories<MauSac> repos = 
                new AllRepositories<MauSac>(context, context.MauSacs);
            irepos = repos;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<MauSac> Get()
        {
            return irepos.GetAll(); 
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public MauSac Get(Guid id)
        {
            return irepos.GetAll().First(p=> p.Id == id);
        }

        [HttpPost("create-mausac")]
        public bool CreateColor(string ma, string ten)
        {
            MauSac color = new MauSac();
            color.Ma = ma; color.Ten = ten; color.Id = Guid.NewGuid();  
            return irepos.CreateItem(color);    
        }
        [HttpPut]
        [Route("edit-mausac")]
        public bool UpdateColor(Guid id, string ma, string ten)
        {
            // Trỏ đến màu sắc trong db để sửa
            MauSac color = irepos.GetAll().First(p=> p.Id == id);
            color.Ten = ten; color.Ma = ma;
            return irepos.UpdateItem(color);
        }
        [HttpDelete("{id}")]
        public bool DeleteColor(Guid id)
        {
            // Trỏ đến màu sắc trong db để sửa
            MauSac color = irepos.GetAll().First(p => p.Id == id);
            return irepos.DeleteItem(color);
        }

    }
}
