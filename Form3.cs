using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkLinq
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)  // Back Button
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Room Button
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e) // Customer Button
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)  // Food Button
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
