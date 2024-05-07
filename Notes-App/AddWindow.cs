using System;
using System.Windows.Forms;

namespace Notes_App
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
