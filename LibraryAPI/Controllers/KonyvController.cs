using LibraryBLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class KonyvController : ControllerBase {
        private readonly ILibraryService libraryService;
        public KonyvController(ILibraryService ls) {
            libraryService = ls;
        }
        // GET: api/<KonyvController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Konyv>>> Get() {
            return (await libraryService.GetKonyvekAsync()).ToList();
        }

        // GET api/<KonyvController>/5
        [HttpGet("{cim?}/{iro?}/{kolcsonzes?}")]
        public async Task<ActionResult<IEnumerable<Konyv>>> Get(string cim, string iro, string kolcsonzes) {
            return (await libraryService.GetKonyvAsync(cim, iro, kolcsonzes)).ToList();
        }

        // POST api/<KonyvController>
        [HttpPost]
        public async Task<ActionResult<Konyv>> Post([FromBody] Konyv konyv) {
            var created = await libraryService.InsertKonyvAsync(konyv);
            return CreatedAtAction(
            nameof(Get),
            new { id = created.Id },
            created);
        }

        // PUT api/<KonyvController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Konyv konyv) {
            await libraryService.UpdateKonyvAsync(id, konyv);
            return NoContent();
        }

        // DELETE api/<KonyvController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            await libraryService.DeleteKonyvAsync(id);
            return NoContent();
        }
    }
}
