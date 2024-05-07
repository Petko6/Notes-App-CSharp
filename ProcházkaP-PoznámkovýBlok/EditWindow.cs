using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcházkaP_PoznámkovýBlok
{
    public partial class EditWindow : Form
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        public string Title { get { return textBoxTitleEdit.Text; } set { textBoxTitleEdit.Text = value; } }
        public string NoteText { get { return richTextBoxTextEdit.Text; } set { richTextBoxTextEdit.Text = value; } }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoteText) && !string.IsNullOrEmpty(Title))
                this.DialogResult = DialogResult.OK;
            else
                //this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Jedno z polí je prázdné!");
        }
    }
}
