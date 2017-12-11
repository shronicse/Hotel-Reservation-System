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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataClasses1DataContext dbCon = new DataClasses1DataContext();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)  // Login 
        {
            try
            {
                DataClasses1DataContext dbCon = new DataClasses1DataContext();
                int password = Int32.Parse(passwordTxt.Text);
                string name = nameTxt.Text;
                admin an = dbCon.admins.SingleOrDefault(x => x.password == password && x.name == name);
                if (an != null)
                {

                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else
                    MessageBox.Show("Incorrect name or Password !!","ErorMesage",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please fill all form ","ErrorMessage",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
