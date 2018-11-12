using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminradio.Checked)
            {
                if (textBox1.Text == "shagufta" && textBox2.Text == "2016cse140")
                {
                    MessageBox.Show("Login Success");
                    Console.ReadLine();
                }
                else
                    MessageBox.Show("Login Failed");
                adminradio.Checked = false;
            }
            else if (studentradio.Checked == true)
            {
                if (textBox1.Text == "shamsiya" && textBox2.Text == "2016cse123")
                {
                    MessageBox.Show("Login Success");
                    Console.ReadLine();
                }
                else
                    MessageBox.Show("Invalid Credentials");
                studentradio.Checked = false;
            }
            else if (facultyradio.Checked == true)
            {
                if (textBox1.Text == "Krishna" && textBox2.Text == "2016cse321")
                {
                    MessageBox.Show("Login Success");
                    Console.ReadLine();
                }
                else
                { MessageBox.Show("Invalid Credentials"); }
                facultyradio.Checked = false;
            }
            else
                MessageBox.Show("Select something atleast");
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
