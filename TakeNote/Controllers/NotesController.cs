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
        public void Post([FromBody] NoteBody noteBody)
        {
            NoteCollection.AddNote(noteBody.Body);
        }

        [HttpGet]
        public IEnumerable<Notes> Get([FromQuery] string query)
        {
            if (query != null)
            {
                // Return notes based on search query
                return NoteCollection.Find(query);
            }
            else
            {
                // Return all the notes
                return NoteCollection.GetInstance();
            }
        }
    }
}