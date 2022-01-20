using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace progetto_del_20_01
{
    public partial class Form1 : Form
    {
        volatile Random rnd;
        volatile int squadreLette;
        volatile object lockCampo;
        Thread arbitro;
        Thread[] partite; //gestore delle partite

        Dictionary<int, string> associazioni = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
            associazioni.Add(0, "V");
            associazioni.Add(1, "F");
            associazioni.Add(2, "S");
            associazioni.Add(4, "Q");
            associazioni.Add(8, "O");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../../../Squadre.txt");
            string ln;
            int i = 1;
            while (!sr.EndOfStream)
            {
                ln = sr.ReadLine();
                Controls["txtq"+(i++).ToString()].Text = ln;
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
            while (squadreLette > 0)
            {
                eseguiTurno(squadreLette/2);
                squadreLette /= 2;
            }
        }

        private void eseguiTurno(int totalePartite)
        {
            int part;
            TextBox[] txtS;
            partite = new Thread[totalePartite];
            for(int i = 0; i < totalePartite*2; i += 2)
            {
                part = i/2;
                partite[i] = new Thread(avviaPartita);
                txtS = new TextBox[3];
                txtS[0] = (TextBox)Controls["txt" + associazioni[totalePartite] + (i + 1).ToString()];
                txtS[1] = (TextBox)Controls["txt" + associazioni[totalePartite] + (i + 2).ToString()];
                txtS[2] = (TextBox)Controls["txt" + associazioni[totalePartite/2] + (part + 1).ToString()];
                partite[part].Start(txtS);
            }
            for(int i = 0;i < totalePartite; i++)
            {
                partite[i].Join();
            }
        }

        private void avviaPartita(object parametri)
        {
            TextBox txtSq1 = (parametri as TextBox[])[0];
            TextBox txtSq2 = (parametri as TextBox[])[1];
            TextBox txtVincitore1 = (parametri as TextBox[])[2];
            TextBox txtVincitore2 = (parametri as TextBox[])[3];
            string sq1 = txtSq1.Text;
            string sq2 = txtSq2.Text;
            string vincitore = "";
            int gol1 = 0, gol2 = 0;
            int tempoMin = 0;
            int tempoPerGol = 0;
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
            Thread.Sleep(rnd.Next(100, 2000));
            lock (lockCampo)
            {
                setCampo(sq1, sq2);
                while (tempoMin > 0)
                {
                    tempoPerGol = rnd.Next(500, 1500);
                    Thread.Sleep(tempoPerGol);
                    tempoMin -= tempoPerGol;
                    if (tempoPerGol % 2 == 0)
                        gol2++;
                    else
                        gol1++;
                    //set campo
                }
            }
        }

        private void setCampo(string sq1, string sq2)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lblSQ1.Text = sq1;
                lblSQ2.Text = sq2;
            });
        }
    }
}
