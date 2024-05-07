using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notes_App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Note note;

        bool IsSelected { get { return listBoxNotes.SelectedIndex != -1; } }

        public void Add()
        {
            AddWindow addWindow = new AddWindow();
            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                listBoxNotes.Items.Add(new Note(addWindow.Title, addWindow.NoteText));
            }
        }

        public void Edit()
        {
            EditWindow editWindow = new EditWindow();
            if (IsSelected)
            {
                note = listBoxNotes.SelectedItem as Note;
                editWindow.Title = note.Title;
                editWindow.NoteText = note.Text;
                if (editWindow.ShowDialog() == DialogResult.OK)
                    note.EditNote(editWindow.Title, editWindow.NoteText);
                listBoxNotes.Items[listBoxNotes.SelectedIndex] = listBoxNotes.Items[listBoxNotes.SelectedIndex];
            }
        }

        public void Delete()
        {
            if (IsSelected)
                listBoxNotes.Items.RemoveAt(listBoxNotes.SelectedIndex);
        }

        public void Open()
        {
            ViewWindow viewWindow = new ViewWindow();
            if (IsSelected)
                note = listBoxNotes.SelectedItem as Note;
            viewWindow.Text = note.Title;
            viewWindow.NoteText = note.Text;
            viewWindow.ShowDialog();
        }
        public void LoadFile(string jmenoSouboru)
        {
            StreamReader streamreader = new StreamReader(jmenoSouboru, Encoding.UTF8);
            streamreader.ReadLine();
            string line;
            while (!streamreader.EndOfStream)
            {
                line = streamreader.ReadLine();
                listBoxNotes.Items.Add(new Note(line));
            }
            streamreader.Close();
        }
        public void SaveFile(string jmenoSouboru)
        {
            StreamWriter streamwriter = new StreamWriter(jmenoSouboru, false, Encoding.UTF8);
            streamwriter.WriteLine("title;text");
            foreach (Note produkt in listBoxNotes.Items)
            {
                streamwriter.WriteLine(produkt.SaveAsCSV());
            }
            streamwriter.Close();
            MessageBox.Show("Uloženo");
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile("notes.csv");
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile("notes.csv");
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tabulkový seznam|*.csv";
            saveFileDialog.Title = "Uložit seznam poznámek";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            SaveFile(fileName);
        }

        private void LoadAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tabulkový seznam|*.csv";
            openFileDialog.Title = "Načíst seznam poznámek";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            LoadFile(fileName);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void listBoxNotes_DoubleClick(object sender, EventArgs e)
        {
            Open();
        }
    }
}
