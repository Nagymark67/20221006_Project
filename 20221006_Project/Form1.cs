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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Projekt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Game jatek = new Form_Game();
            jatek.ShowDialog(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            this.Close();
        }        
    }
}
