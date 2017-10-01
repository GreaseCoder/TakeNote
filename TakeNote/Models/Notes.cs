using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeNote.Models
{
    public class NoteBody
    {
        public string Body { get; set; }
    }

    public class Notes
    {
        public int ID { get; set; }
        public string Body { get; set; }

        public Notes(int sourceID, string sourceString)
        {
            ID = sourceID;
            Body = sourceString;
        }
    }
}
