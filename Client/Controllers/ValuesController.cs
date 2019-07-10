using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;
using Client.Services;
using Microsoft.AspNetCore.Mvc;
using WebApiClient;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IPersonApiService _personApiService;
        public ValuesController(IPersonApiService personApiService)
        {
            _personApiService = personApiService;
        }
        // GET api/values
        [HttpGet]
        public async Task<List<Person>> GetAsync()
        {
            return await _personApiService.GetAllPersonsAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
