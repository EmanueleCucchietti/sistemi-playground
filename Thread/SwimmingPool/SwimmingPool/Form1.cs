using System.IO;

namespace SwimmingPool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readPlayers();
        }

        private void readPlayers()
        {
            lblBeforePlayers.Text = "";
            StreamReader sr = new StreamReader("../../../txt/Players.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                lblBeforePlayers.Text += "\n"+line;
            }
        }
    }
}