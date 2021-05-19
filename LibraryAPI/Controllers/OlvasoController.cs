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
    public class OlvasoController : ControllerBase {
        private readonly ILibraryService libraryService;
        public OlvasoController(ILibraryService ls) {
            libraryService = ls;
        }
        // GET: api/<OlvasoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Olvaso>>> Get() {
            return (await libraryService.GetOlvasokAsync()).ToList();
        }

        // GET api/<OlvasoController>/5
        [HttpGet("{nev}")]
        public async Task<ActionResult<IEnumerable<Olvaso>>> Get(string nev) {
            return (await libraryService.GetOlvasoAsync(nev)).ToList();
        }


        // POST api/<OlvasoController>
        [HttpPost]
        public async Task<ActionResult<Olvaso>> Post([FromBody] Olvaso olvaso) {
            var created = await libraryService.InsertOlvasoAsync(olvaso);
            return CreatedAtAction(
            nameof(Get),
            new { id = created.Id },
            created);
        }

        // PUT api/<OlvasoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Olvaso olvaso) {
            await libraryService.UpdateOlvasoAsync(id, olvaso);
            return NoContent();
        }

        // DELETE api/<OlvasoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            await libraryService.DeleteOlvasoAsync(id);
            return NoContent();
        }
    }
}
