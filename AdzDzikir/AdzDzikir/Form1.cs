using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdzDzikir
{
    public partial class Form1 : Form
    {
        bool isPanelShow = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void CountDzikir(object obj, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            if (circularProgressBar1.Value == circularProgressBar1.Maximum)
                MessageBox.Show("Dzikir Selesai !!!", "Pengumuman !");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                case Keys.J:
                    circularProgressBar1.Value += 1;
                    break;
            }

        }

        private void SetLoopValue_Click(object sender, EventArgs e)
        {
            LoopValue.Visible = !LoopValue.Visible;
            if (!LoopValue.Visible && LoopValue.Text.Length != 0)
            {
                circularProgressBar1.Maximum = int.Parse(LoopValue.Text);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
        }

        private void switcherPanel()
        {
            timer1.Start();
            isPanelShow = !isPanelShow;
        }

        private void ClosePanel()
        {
            if (panel1.Location.X >= -225)
            {
                panel1.Left -= 5;
            }
            else
            {
                timer1.Stop();
            }
        }
        private void OpenPanel()
        {
            if (panel1.Location.X <= -2)
            {
                panel1.Left += 5;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPanelShow)
            {
                OpenPanel();
            }
            else
            {
                ClosePanel();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switcherPanel();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPanelShow)
            {
                if (e.Button == MouseButtons.Left)
                {
                    switcherPanel();
                }
            }
        }
    }
}
