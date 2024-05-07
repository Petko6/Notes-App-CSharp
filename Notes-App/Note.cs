namespace Notes_App
{
    internal class Note
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public Note(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public Note(string line)
        {
            string[] data = line.Split(';');
            Title = data[0];
            Text = data[1];
        }

        public override string ToString()
        {
            return Title;
        }

        public void EditNote(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string SaveAsCSV()
        {
            return $"{Title};{Text}";
        }
    }
}
