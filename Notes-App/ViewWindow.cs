using System.Windows.Forms;

namespace Notes_App
{
    public partial class ViewWindow : Form
    {
        public ViewWindow()
        {
            InitializeComponent();
        }
        public string NoteText { get { return richTextBoxTextView.Text; } set { richTextBoxTextView.Text = value; } }
    }
}
