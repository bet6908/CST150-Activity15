using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150_Activity15
{
    public partial class Results1 : Form
    {
        public Results1()
        {
            InitializeComponent();
        }

        private void Results1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                textBox1.Text = rnd.Next(100).ToString();
            }

            label1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
