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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
           
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        

      

       

       
    }
}
