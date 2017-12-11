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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLinqDataSet4.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.dBLinqDataSet4.Food);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext dbCon = new DataClasses1DataContext();
                Food fd = new Food();
                fd.FoodId = Convert.ToInt32(FoodIdTxt.Text);
                fd.FoodName = FoodNameTxt.Text;
                fd.Price = Convert.ToInt32(PriceTxt.Text);
                fd.FoodStatus = comboBox1.Text;
                dbCon.Foods.InsertOnSubmit(fd);
                dbCon.SubmitChanges();
                MessageBox.Show("Food Added !!");
                this.foodTableAdapter.Fill(this.dBLinqDataSet4.Food);
                FoodIdTxt.Text = null;
                FoodNameTxt.Text = null;
                PriceTxt.Text = null;
                comboBox1.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check all data ","ErrorMessage",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                FoodIdTxt.Text = row.Cells[0].Value.ToString();
                FoodNameTxt.Text = row.Cells[1].Value.ToString();
                PriceTxt.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            int foodId = Convert.ToInt32(FoodIdTxt.Text);
            Food fd = dbCon.Foods.SingleOrDefault(x => x.FoodId == foodId);
            if(fd != null)
            {
                fd.FoodName = FoodNameTxt.Text;
                fd.Price =Convert.ToInt32 (PriceTxt.Text);
                fd.FoodStatus = comboBox1.Text;
                dbCon.SubmitChanges();
                MessageBox.Show("Data Updated ");
                this.foodTableAdapter.Fill(this.dBLinqDataSet4.Food);
                FoodIdTxt.Text = null;
                FoodNameTxt.Text = null;
                PriceTxt.Text = null;
                comboBox1.Text = null;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            int foodId = Convert.ToInt32(FoodIdTxt.Text);
            Food fd = dbCon.Foods.SingleOrDefault(x => x.FoodId == foodId);
            if (fd != null)
            {
                dbCon.Foods.DeleteOnSubmit(fd);
                dbCon.SubmitChanges();
                MessageBox.Show("Data Deleted ");
                this.foodTableAdapter.Fill(this.dBLinqDataSet4.Food);
                FoodIdTxt.Text = null;
                FoodNameTxt.Text = null;
                PriceTxt.Text = null;
                comboBox1.Text = null;
            }
            else
                MessageBox.Show("This Id is not avilable in Database ","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            int foodId = Convert.ToInt32(FoodIdTxt.Text);
            Food fd = dbCon.Foods.SingleOrDefault(x => x.FoodId == foodId);
        }

        private void searchTxt(object sender, KeyEventArgs e)
        {
           /* DataClasses1DataContext dbCon = new DataClasses1DataContext();
            dataGridView1.DataSource = from food in dbCon.Foods
                                       where food.FoodName.StartsWith()
                                       select food;*/
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            dataGridView1.DataSource = from food in dbCon.Foods
                                       where food.FoodName.StartsWith(textBox1.Text)
                                           select food;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
