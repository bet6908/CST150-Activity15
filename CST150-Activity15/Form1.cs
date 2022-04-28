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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country() { ID = 1, Name = "United States" });
            countries.Add(new Country() { ID = 2, Name = "Mexico" });
            countries.Add(new Country() { ID = 3, Name = "Canada" });
            countries.Add(new Country() { ID = 4, Name = "Alaska" });
            countries.Add(new Country() { ID = 5, Name = "Brazil" });
            countries.Add(new Country() { ID = 6, Name = "Honduras" });
            countries.Add(new Country() { ID = 7, Name = "Venezuela" });
            countries.Add(new Country() { ID = 8, Name = "Cuba" });
            countries.Add(new Country() { ID = 9, Name = "Colombia" });
            countries.Add(new Country() { ID = 10, Name = "Afghanistan" });
            countries.Add(new Country() { ID = 11, Name = "Germany" });
            countries.Add(new Country() { ID = 12, Name = "Japan" });
            Country_lb.DataSource = countries;
            Country_lb.ValueMember = "ID";
            Country_lb.DisplayMember = "Name";

            List<Priority> priorities = new List<Priority>();
            priorities.Add(new Priority() { ID = 1, Name = "Extremely Urgent" });
            priorities.Add(new Priority() { ID = 2, Name = "Urgent" });
            priorities.Add(new Priority() { ID = 3, Name = "Somewhat Urgent" });
            priorities.Add(new Priority() { ID = 4, Name = "Moderate" });
            priorities.Add(new Priority() { ID = 5, Name = "Mild" });
            priorities.Add(new Priority() { ID = 6, Name = "No importance" });
            Priority_lb.DataSource = priorities;
            Priority_lb.ValueMember = "ID";
            Priority_lb.DisplayMember = "Name";

            button1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void Country_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country obj = Country_lb.SelectedItem as Country;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Priority obj = Priority_lb.SelectedItem as Priority;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Results1().Show();
        }
    }
}
