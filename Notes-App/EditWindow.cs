using System;
using System.Windows.Forms;

namespace Notes_App
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
                MessageBox.Show("Jedno z polí je prázdné!");
        }
    }
}
