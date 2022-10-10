using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20221006_Project
{
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();
        }

        private void Form_Game_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Image = Properties.Resources.FighterJet;
            button1.Location = new Point(Form_Game.ActiveForm.Size.Width/2-button1.Width/2, Form_Game.ActiveForm.Size.Height/2-button1.Height/2);
        }

        private void Form_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = new Form1();
            main.ShowDialog(this);
            this.Hide();
        }
    }
}
