using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BógMówi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Pamiętaj o Mnie.","Twój Bóg mówi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            timer2.Enabled = true;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("d1.wav"); sp.Play();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Hide();
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random los = new Random();
            int liczba = los.Next(10);
            timer1.Interval += los.Next(500);
            timer1.Interval -= los.Next(500);
            switch(liczba)
            {
                case 0: MessageBox.Show("Czy pamiętasz o modlitwie? O modlitwie za zmarłych?", "Twój Bóg mówi", MessageBoxButtons.OK, MessageBoxIcon.Question); break;
                case 1: MessageBox.Show("Czy nie za często poddajesz sięzłemu duchowi?", "Twój Bóg mówi", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case 2: MessageBox.Show("Czy chcesz osiągnąć Niebo? Czy tęsknisz za tym?", "Twój Bóg mówi", MessageBoxButtons.OK, MessageBoxIcon.Question); break;
                case 3: MessageBox.Show("Czy słyszysz Mnie i słuchasz Mnie?", "Twój Bóg mówi", MessageBoxButtons.OK, MessageBoxIcon.Question); break;
                case 4: MessageBox.Show("Kocham ciebie. Jesteś Dzieckiem Bożym. Pamiętaj!", "Twój Bóg mówi", MessageBoxButtons.OK, MessageBoxIcon.Hand); break;
                case 5: System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer("d1.wav"); sp1.Play(); break;
                case 6: System.Media.SoundPlayer sp2 = new System.Media.SoundPlayer("d2.wav"); sp2.Play(); break;
                case 7: System.Media.SoundPlayer sp3 = new System.Media.SoundPlayer("d3.wav"); sp3.Play(); break;
                case 8: System.Media.SoundPlayer sp4 = new System.Media.SoundPlayer("d4.wav"); sp4.Play(); break;
                case 9: System.Media.SoundPlayer sp5 = new System.Media.SoundPlayer("d5.wav"); sp5.Play(); break;
            }
        }
    }
}
