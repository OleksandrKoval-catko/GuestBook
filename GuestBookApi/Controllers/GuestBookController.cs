using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GuestBookApi.Context;
using GuestBookApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBookApi.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class GuestBookController : Controller
    {
        MainContext _context;
        public GuestBookController(MainContext mainContext)
        {
            _context = mainContext;
        }

        [HttpGet("GetComments")]
        public IEnumerable<GuestNote> GetComments()
        {
            return _context.GuestNotes;
        }

        [HttpPost("PostComment")]
        public async Task<IActionResult> PostComment([FromBody] GuestNote guestNote)
        {
            if (guestNote.Name == null || guestNote.Comment == null) return BadRequest("Empty");

            try
            {
                guestNote.Date = System.DateTime.Now;
                await _context.GuestNotes.AddAsync(guestNote);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return Ok();

        }


    }
}