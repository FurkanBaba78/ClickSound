using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog file = new OpenFileDialog();
        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                player.SoundLocation = path;
                player.Play();
            }
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "WAV Audio File |*.wav";
            file.ShowDialog();  // openfiledialog ekranını açıyoruz.
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                label1.Text = DosyaAdi;
            path = DosyaYolu;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label6.Text = "Status: ON";
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label6.Text = "Status: OFF";
            timer1.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://cdn.discordapp.com/attachments/776958985889644545/779510553243549696/sounds.rar");
        }
    }
}
