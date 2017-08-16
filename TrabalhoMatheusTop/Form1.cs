using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMatheusTop
    
    
{
    public partial class Form1 : Form
        
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = random.Next(2);
            if (n == 0) 
            {
                button1.Text = "KK foi Trollado";
            }
           else
            {
                button1.Text="Salvo.jpeg";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = random.Next(2);
            if (n == 0)
            {
                button2.Text = "KK foi Trollado";
            }
            else
            {
                button2.Text = "Salvo.jpeg";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = random.Next(2);
            if (n == 0)
            {
                button4.Text = "KK foi Trollado";
            }
            else
            {
                button4.Text = "Salvo.jpeg";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = random.Next(2);
            if (n == 0)
            {
                button3.Text = "KK foi Trollado";
            }
            else
            {
                button3.Text = "Salvo.jpeg";
            }
        }
    }
}
