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
    public class KolcsonzesController : ControllerBase {
        private readonly ILibraryService libraryService;
        public KolcsonzesController(ILibraryService ls) {
            libraryService = ls;
        }
        // GET: api/<KolcsonzesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kolcsonzes>>> Get() {
            return (await libraryService.GetKolcsonzesekAsync()).ToList();
        }

        // GET api/<KolcsonzesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Kolcsonzes>>> Get(int id) {
            return (await libraryService.GetKolcsonzesAsync(id)).ToList();
        }

        // POST api/<KolcsonzesController>
        [HttpPost]
        public async Task<ActionResult<Kolcsonzes>> Post([FromBody] Kolcsonzes kolcsonzes) {
            var created = await libraryService.InsertKolcsonzesAsync(kolcsonzes);
            return CreatedAtAction(
            nameof(Get),
            new { id = created.Id },
            created);
        }

        // DELETE api/<KolcsonzesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            await libraryService.DeleteKolcsonzesAsync(id);
            return NoContent();
        }
    }
}
