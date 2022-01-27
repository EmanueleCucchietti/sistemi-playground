using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Torneo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            associazioni.Add(0, "V");
            associazioni.Add(1, "F");
            associazioni.Add(2, "S");
            associazioni.Add(4, "Q");
            associazioni.Add(8, "O");
            //Associazioni relative alla FORM
        }

        volatile Random rnd;
        volatile int squadreLette;
        volatile object lock_campo = new object();

        Thread arbitro;
        Thread[] partite; //Gestore delle partite

        Dictionary<int, string> associazioni = new Dictionary<int, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("squadre.txt");
            string line;
            int i = 1;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                Controls["txtQ" + i.ToString()].Text = line;
                Controls["txtQ" + i.ToString()].BackColor = Color.White;
                i++;
            }
            sr.Close();
            squadreLette = i - 1;
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            rnd = new Random();

            arbitro = new Thread(arbitroThread);
            arbitro.Start();
        }

        private void arbitroThread()
        {
            while(squadreLette > 0)
            {
                eseguiTurno(squadreLette / 2);
                squadreLette /= 2;
            }
        }

        private void eseguiTurno(int totalePartite)
        {
            int part;
            TextBox[] txtS;
            partite = new Thread[totalePartite];
            for (int i = 0; i < totalePartite * 2; i += 2)
            {
                part = i / 2;
                partite[part] = new Thread(avviaPartita);
                txtS = new TextBox[3];
                txtS[0] = (TextBox) Controls["txt" + associazioni[totalePartite] + (i + 1).ToString()];
                txtS[1] = (TextBox) Controls["txt" + associazioni[totalePartite] + (i + 2).ToString()];
                txtS[2] = (TextBox) Controls["txt" + associazioni[totalePartite / 2] + (part + 1).ToString()];
                partite[part].Start(txtS);
            }

            for (int i = 0; i < totalePartite; i++)
                partite[i].Join();
        }

        private void avviaPartita(object parametri)
        {
            TextBox txtSq1 = (parametri as TextBox[])[0];
            TextBox txtSq2 = (parametri as TextBox[])[1];
            TextBox txtVincitore = (parametri as TextBox[])[2];
            string sq1 = txtSq1.Text;
            string sq2 = txtSq2.Text;
            string vincitore = "";
            int goal1 = 0, goal2 = 0;
            int tempoMin = 0;
            int tempoPerGoal = 0;

            switch (txtSq1.Name[3])
            {
                case 'Q':
                    tempoMin = 10000;
                    break;
                case 'S':
                    tempoMin = 15000;
                    break;
                case 'F':
                    tempoMin = 20000;
                    break;
            }
            Thread.Sleep(rnd.Next(100, 1000));
            lock (lock_campo)
            {
                setCampo(sq1, sq1);

                while(tempoMin > 0 || goal1 == goal2)
                {
                    tempoPerGoal = rnd.Next(500, 1500);
                    Thread.Sleep(tempoPerGoal);
                    tempoMin -= tempoPerGoal;
                    if (tempoPerGoal % 2 == 0)
                        goal2++;
                    else
                        goal1++;

                    setCampo(sq1 + " " + goal1.ToString(), goal2.ToString() + " " + sq2);
                }
            } //FINE SEZIONE CRITICA

            vincitore = (goal1 > goal2) ? sq1 : sq2;

            setCampo("", "");
            Thread.Sleep(rnd.Next(100, 800));

            BeginInvoke((MethodInvoker)delegate ()
            {
                textBox1.Text += sq1 + " " + goal1 + " - " + sq2 + " " + goal2 + Environment.NewLine;
                txtVincitore.Text = vincitore;
                txtVincitore.BackColor = Color.White;
            });
        }

        private void setCampo(string sq11, string sq12)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lblSq1.Text = sq11;
                lblSq2.Text = sq12;
            });
        }
    }
}
