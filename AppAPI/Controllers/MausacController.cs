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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
