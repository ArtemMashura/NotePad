using MVC_practice.Model;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;

namespace MVC_practice.Controls
{
    public class NoteControl : IDisposable
    {
        public int IDgen = 0;
        public List<Note> notes { set; get; }
        public NoteControl()
        {
            if (File.Exists("data.json"))
            {
                notes = new List<Note>(JsonSerializer.Deserialize<List<Note>>(File.ReadAllText("data.json")));
                foreach (Note note in notes)
                {
                    if (note.Id > IDgen)
                    {
                        IDgen = note.Id;
                    }
                }
            }
            else { notes = new List<Note>(); }
        }

        public void Dispose()
        {
            string jsonString = JsonSerializer.Serialize(notes);
            File.WriteAllText("data.json", jsonString);
        }

        public void Add(Note note)
        {
            IDgen++;
            note.Id = IDgen;
            notes.Add(note);
        }

        public void Remove(int ID)
        {
            int index = notes.FindIndex(x => x.Id == ID);
            notes.RemoveAt(index);
        }

        public void Edit(Note note)
        {
            //Remove(note.Id);
            //Add(note);
            int index = notes.FindIndex(x => x.Id == note.Id);
            notes.RemoveAt(index);
            notes.Insert(index, note);

        }
    }
}
