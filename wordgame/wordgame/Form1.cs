namespace wordgame
{
    public partial class Form1 : Form
    {
        private string[] guessedWords;
        private string[] ToTalWords;
        private string guess;
        private string word;
        public Form1()
        {
            InitializeComponent();
            NewGame();
            ToTalWords = new string[5];
        }
        private void NewGame()
        {
            guessedWords = new string[5];
            ToTalWords = new string[5] { "hero", "mod", "her", "vin", "son"};
            guess = "jaelitpersmubxrfhirrpsrlteosooumuaoieseevaeosonnsnhistesmzcuiovnoeciatnlbrrnoaceocsssairtibhtsdicdoeherbivoreirherovinmodc";

        }
        private void Index()
        {
            string onlywords = "";
            string index = "";
            int k = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ',' || word[i] !=' ')
                {
                    onlywords += word[i];

                }                
                foreach(string s in ToTalWords)
                {
                    if (onlywords == s)
                    {
                        foreach(string s2 in guessedWords)
                        {
                            if (onlywords == s2)
                            {
                                onlywords = "";
                            }
                            else
                            {
                                guessedWords[k] = onlywords;
                                k++;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (onlywords == ToTalWords[i] && onlywords != guessedWords[i])
                {
                    onlywords += guessedWords[i];
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            word = textBox1.Text.ToLower();
        }
    }
}