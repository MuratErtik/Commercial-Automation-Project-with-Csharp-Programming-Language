using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_automation_project1
{
    public partial class NoteDetails : Form
    {
        public NoteDetails()
        {
            InitializeComponent();
        }
        public string text;
        private void NoteDetails_Load(object sender, EventArgs e)
        {
            textNoteDetails.Text = text;
        }
    }
}
