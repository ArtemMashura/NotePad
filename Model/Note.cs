using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_practice.Model
{
    public class Note
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public Note(int id, string date, string title, string text)
        {
            Id = id;
            Date = date;
            Title = title;
            Text = text;
        }

        public Note(string date, string title, string text)
        {
            Id = 0;
            Date = date;
            Title = title;
            Text = text;
        }
        
        public Note()
        {

        }
    }
}
