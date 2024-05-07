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
    public partial class ViewWindow : Form
    {
        public ViewWindow()
        {
            InitializeComponent();
        }
        public string NoteText { get { return richTextBoxTextView.Text; } set { richTextBoxTextView.Text = value; } }
    }
}
