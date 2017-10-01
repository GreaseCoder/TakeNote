using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakeNote.Models;

namespace TakeNote.Controllers
{
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        [HttpGet("{id}")]
        public Notes Get(int id)
        {
            return NoteCollection.GetNote(id);
        }

        // POST api/notes
        [HttpPost]
        public void Post([FromBody] string json)
        {
            NoteCollection.AddNote(json);
        }

        [HttpGet]
        public IEnumerable<Notes> Get([FromQuery] string query)
        {
            return NoteCollection.Find(query);
        }
    }
}