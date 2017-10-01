using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TakeNote.Models
{
    public class NoteCollection
    {
        private static HashSet<Notes> noteCollection = new HashSet<Notes>();
        public static HashSet<Notes> GetInstance()
        {
            return noteCollection;
        }

        private static int count = 0;

        /// <summary>
        /// Saves a note
        /// </summary>
        public static void AddNote(string body)
        {
            lock (noteCollection)
            {
                noteCollection.Add(new Notes(++count, body));
            }
        }

        /// <summary>
        /// Returns a note with the respective ID.
        /// </summary>
        public static Notes GetNote(int id)
        {
            return noteCollection.FirstOrDefault(x => x.ID == id);
        }

        /// <summary>
        /// Returns a list of notes which have a match with the search value in their body.
        /// </summary>
        /// <param name="search">Value being searched for</param>
        public static IEnumerable<Notes> Find(string search)
        {
            return noteCollection.Where(x => Regex.IsMatch(x.Body, search, RegexOptions.IgnoreCase));
        }
    }
}
