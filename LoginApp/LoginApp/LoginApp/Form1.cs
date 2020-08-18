using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Rafael" && textBox3.Text == "1234")
            {
                MessageBox.Show("Login Efetuado !");
            }
   
            if (textBox2.Text == "Jorge" && textBox3.Text == "abacaxi")
            {
                MessageBox.Show("Login Efetuado !");
            }
            if (textBox2.Text == "Ana Lins" && textBox3.Text == "euseila")
            {
                MessageBox.Show("Login Efetuado !");
            }
            if (textBox2.Text == "Adolfo" && textBox3.Text == "abacaxi")
            {
                MessageBox.Show("Login Efetuado !");
            }
            else MessageBox.Show("Login ou senha inválidos");

        }
    }
}
