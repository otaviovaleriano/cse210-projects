  class Scripture
    {
        public string Reference { get; set; }
        public string Text { get; set; }
        public List<Word> Words { get; set; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
            Words = new List<Word>();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                Words.Add(new Word(word));
            }
        }
    }
