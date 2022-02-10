using System.IO;
using System.Threading;

namespace SwimmingPool
{
    public partial class Form1 : Form
    {
        Thread arbitro;
        Thread[] atlBatterie;
        volatile int atletiLetti;
        volatile Random rnd;
        const int MAX_BORDER = 720;
        volatile List<Player> playerList = new List<Player>();
        int BATTERIE=4;

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
            lblAtleti.Text = "";
            StreamReader sr = new StreamReader("../../../txt/Players.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Player player = new Player(line);
                playerList.Add(player);
            }
            sr.Close();
            stampaPlayers();
            atletiLetti = playerList.Count;
        }
        private void stampaPlayers()
        {
            //viene creato un nuovo thread che esegue la funzione anonima al suo interno
            BeginInvoke((MethodInvoker)delegate ()
            {
                lblAtleti.Text = "";
                foreach (Player player in playerList)
                {
                    if (!player.HasPlayed)
                    {
                        lblAtleti.Text += "\n" + player.Name;
                    }
                }
            });
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            lblEsito.Text = "";
            lblEliminati.Text = "";
            arbitro = new Thread(   arbitroThread);
            arbitro.Start();
        }

        private void arbitroThread()
        {
            int atletiResidui = atletiLetti;
            int turno = 0;
            while(atletiResidui > 0)
            {
                setValore(lblTurno, "Turno: " + (++turno).ToString());
                eseguiGara();
                atletiResidui -= BATTERIE;

                atletiResidui -= 4;
            }
            MessageBox.Show("Eliminatorie Terminate");
        }

        private void eseguiGara()
        {
            int posAtl;
            TextBox txtA;
            
            atlBatterie = new Thread[BATTERIE];

            for(int i=0;i<BATTERIE;i++)
            {
                txtA = new TextBox();
                txtA = (TextBox)Controls["txtA" + (i+1).ToString()];

                posAtl = rnd.Next(0, atletiLetti);
                while (playerList[posAtl].HasPlayed)
                {
                    posAtl = rnd.Next(0, atletiLetti);
                }
                playerList[posAtl].HasPlayed = true;
                BeginInvoke((MethodInvoker)delegate ()
                {
                    txtA.Text = playerList[posAtl].Name.ToString();

                });
                Thread.Sleep(100);
                atlBatterie[i] = new Thread(garaAtleta);
                atlBatterie[i].Name = playerList[posAtl].Name;
                atlBatterie[i].Start(txtA);

            }
            setValore(lblStato, "PRONTI...");
            for(int i=0; i<BATTERIE;i++)
                atlBatterie[i].Join();
            Thread.Sleep(3000);
        }


        private void garaAtleta(object parametri)
        {
            TextBox txtAtl = (parametri as TextBox);
            Thread.Sleep(1000);
        }
        private void setValore(Label lbl, string output)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lbl.Text = output;
            });
        }
    }
}