using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_practice.View
{
    public partial class EditForm : Form
    {
        public string NewDate { get; set; } = null;
        public string NewTitle { get; set; } = null;
        public string NewText { get; set; } = null;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string date, string title, string text)
        {
            InitializeComponent();
            EditDateTB.Text = date;
            EditTitleTB.Text = title;
            EditTextTB.Text = text;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            NewDate = EditDateTB.Text;
            NewTitle = EditTitleTB.Text;
            NewText = EditTextTB.Text;
            Close();
        }
    }
}
