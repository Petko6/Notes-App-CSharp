using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProcházkaP_PoznámkovýBlok
{
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        public string Title { get { return textBoxTitleAdd.Text; } set { textBoxTitleAdd.Text = value; } }
        public string NoteText { get { return richTextBoxTextAdd.Text; } set { richTextBoxTextAdd.Text = value; } }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoteText) && !string.IsNullOrEmpty(Title))
                this.DialogResult = DialogResult.OK;
            else
                //this.DialogResult = DialogResult.Cancel;7
                MessageBox.Show("Jedno z polí je prázdné!");
        }
    }
}
