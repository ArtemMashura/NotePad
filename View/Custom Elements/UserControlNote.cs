using MVC_practice.Controls;
using MVC_practice.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_practice.Model
{
    public partial class UserControlNote : UserControl
    {
        NoteControl noteControl = new NoteControl();
        public UserControlNote()
        {
            InitializeComponent();
        }

        public int ID;
        public string Date;
        public string Title;
        public string Text1;

        public bool ifForRemove = false;
        public UserControlNote(int id, string date, string title, string text)
        {
            InitializeComponent();
            ID = id;
            Date = date;
            dateLabel.Text = date;
            Title = title;
            titleLabel.Text = title;
            Text1 = text;
            textLabel.Text = text;
        }

        private void Edit_BTN_Click(object sender, EventArgs e)
        {
            using (EditForm editForm = new EditForm(dateLabel.Text, titleLabel.Text, textLabel.Text))
            {
                editForm.ShowDialog();
                if (editForm.NewDate != null && editForm.NewTitle != null && editForm.NewText != null)
                {
                    Date = editForm.NewDate;
                    dateLabel.Text = editForm.NewDate;
                    Title = editForm.NewTitle;
                    titleLabel.Text = editForm.NewTitle;
                    Text1 = editForm.NewText;
                    textLabel.Text = editForm.NewText;

                }
                GC.Collect(GC.GetGeneration(editForm));
                Note note = new Note(ID, dateLabel.Text, titleLabel.Text, textLabel.Text);
                noteControl.Edit(note);

            }
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            ifForRemove = true;
        }

        public void TitleCheck(string title)
        {
            if (titleLabel.Text.Contains(title))
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = SystemColors.GradientActiveCaption;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ifForRemove = !ifForRemove;
        }

        
    }
}
