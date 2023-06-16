using MVC_practice.Controls;
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MVC_practice.Model;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices.ComTypes;



namespace MVC_practice
{
    public partial class MainForm1 : Form
    {
        public NoteControl noteControl =  new NoteControl();
        public MainForm1()
        {
            InitializeComponent();
            OnLoad();
        }

        private void noteSave_BTN_Click_1(object sender, EventArgs e)
        {
            string date = DateTB.Text;
            string title = TitleTB.Text;
            string text = TextTB.Text;
            DateTB.Text = null;
            TitleTB.Text = null;
            TextTB.Text = null;
            noteControl.Add(new Note(date, title, text));
            RemoveAll();
            OnLoad();
        }

        public void AddCustomNote(int ID, string date, string title, string text)
        {
            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(text))
            {
                ErrorLabel.Visible = true;
                return;
            }
            else
            {
                ErrorLabel.Visible = false;
                flowLayoutPanel1.Controls.Add(new UserControlNote(ID, date, title, text));
            }
        }

        private void FindBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FindTB.Text))
            {
                FindErrorLabel.Visible = true;
                return;
            }
            else
            {
                FindErrorLabel.Visible = false;
            }
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UserControlNote)
                {
                    UserControlNote C = control as UserControlNote;
                    C.TitleCheck(FindTB.Text);
                }
            }
            FindTB.Text = null;
        }

        public void OnLoad()
        {
            foreach (Note s in noteControl.notes)
            {
                AddCustomNote(s.Id, s.Date, s.Title, s.Text);
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateNotes();
            noteControl.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateNotes();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is UserControlNote)
                {
                    var t = c as UserControlNote;
                    if (t.ifForRemove)
                        noteControl.Remove(t.ID);
                }
            }
            RemoveAll();
            OnLoad();
        }

        public void RemoveAll()
        {
            this.flowLayoutPanel1.Controls.Clear();
        }

        public void UpdateNotes()
        {
            noteControl.notes.Clear();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is UserControlNote)
                {
                    var t = c as UserControlNote;
                    Note note = new Note(t.ID, t.Date, t.Title, t.Text1);
                    noteControl.notes.Add(note);
                }
            }
        }
    }
}
