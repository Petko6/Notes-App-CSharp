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

        Poznámka poznámka;

        bool JeVybrano { get { return listBoxSeznamPoznámek.SelectedIndex != -1; } }

        public void Add()
        {
            AddWindow addWindow = new AddWindow();
            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                listBoxSeznamPoznámek.Items.Add(new Poznámka(addWindow.Title, addWindow.NoteText));
            }
        }

        public void Edit()
        {
            EditWindow editWindow = new EditWindow();
            poznámka = listBoxSeznamPoznámek.SelectedItem as Poznámka;
            if (JeVybrano)
            {
                editWindow.Title = poznámka.Title;
                editWindow.NoteText = poznámka.Text;
                if (editWindow.ShowDialog() == DialogResult.OK)
                {
                    listBoxSeznamPoznámek.Items.Insert(listBoxSeznamPoznámek.SelectedIndex, new Poznámka(editWindow.Title, editWindow.NoteText));
                    listBoxSeznamPoznámek.Items.RemoveAt(listBoxSeznamPoznámek.SelectedIndex);

                }
            }
        }

        public void Delete()
        {
            if (JeVybrano)
                listBoxSeznamPoznámek.Items.RemoveAt(listBoxSeznamPoznámek.SelectedIndex);
        }

        public void Open()
        {
            ViewWindow viewWindow = new ViewWindow();
            if (JeVybrano)
                poznámka = listBoxSeznamPoznámek.SelectedItem as Poznámka;
            viewWindow.Text = poznámka.Title;
            viewWindow.NoteText = poznámka.Text;
            viewWindow.ShowDialog();
        }
        public void NačístSoubor(string jmenoSouboru)
        {
            StreamReader streamreader = new StreamReader(jmenoSouboru, Encoding.UTF8);
            streamreader.ReadLine();
            string radek;
            while (!streamreader.EndOfStream)
            {
                radek = streamreader.ReadLine();
                listBoxSeznamPoznámek.Items.Add(new Poznámka(radek));
            }
            streamreader.Close();
        }
        public void UložitSoubor(string jmenoSouboru)
        {
            StreamWriter streamwriter = new StreamWriter(jmenoSouboru, false, Encoding.UTF8);
            streamwriter.WriteLine("title;text");
            foreach (Poznámka produkt in listBoxSeznamPoznámek.Items)
            {
                streamwriter.WriteLine(produkt.UlozitCSV());
            }
            streamwriter.Close();
            MessageBox.Show("Uloženo");
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void listBoxSeznamPoznámek_DoubleClick(object sender, EventArgs e)
        {
            Open();
        }

        private void načístToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NačístSoubor("notes.csv");
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UložitSoubor("notes.csv");
        }

        private void uložitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tabulkový seznam|*.csv";
            saveFileDialog.Title = "Uložit seznam poznámek";
            saveFileDialog.ShowDialog();
            string názevSouboru = saveFileDialog.FileName;
            UložitSoubor(názevSouboru);
        }

        private void načístJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tabulkový seznam|*.csv";
            openFileDialog.Title = "Načíst seznam poznámek";
            openFileDialog.ShowDialog();
            string názevSouboru = openFileDialog.FileName;
            NačístSoubor(názevSouboru);
        }

        private void přidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void upravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void odstranitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
    }
}
