using IBL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL userBL;

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }


        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return userBL.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public object? Get(int id)
        {
            return userBL.GetById(id);

        }

        // POST api/<UserController>
        [HttpPost]
        public bool Post([FromBody] object value)
        {
            return userBL.Add(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] object value)
        {
            return userBL.Update(value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return userBL.Delete(id);
        }
    }
}
