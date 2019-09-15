using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        static string Rand()
        {
            Random rand = new Random();

            string temp = Convert.ToString(rand.Next(100));
            return temp;

        }

        public Int64 first = 0;
        public Int64 second = 1;

        static int Fib(int first, int second)
        {
            int sum = first + second;
            second = first;
            first = sum;
            return second;
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label1.Text =Rand().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            label1.Text = Fib(first,second).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
