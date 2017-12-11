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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLinqDataSet3.RoomTB' table. You can move, or remove it, as needed.
            this.roomTBTableAdapter.Fill(this.dBLinqDataSet3.RoomTB);
            // TODO: This line of code loads data into the 'dBLinqDataSet2.room' table. You can move, or remove it, as needed.
            //this.roomTableAdapter.Fill(this.dBLinqDataSet2.room);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            RoomTB rm = new RoomTB();
            rm.roomNumber =Int32.Parse( roomNoTxt.Text);
            rm.price = Convert.ToDouble(priceTxt.Text);
            rm.status = comboBox1.SelectedItem.ToString();
            dbCon.RoomTBs.InsertOnSubmit(rm);
            dbCon.SubmitChanges();
            MessageBox.Show("Room Added !!");
            this.roomTBTableAdapter.Fill(this.dBLinqDataSet3.RoomTB);
            roomNoTxt.Text = null;
            priceTxt.Text = null;
            comboBox1.Text = null;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // to show dataGridview on textBox
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roomNoTxt.Text = row.Cells[0].Value.ToString();
                priceTxt.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            int roomNumber = Int32.Parse(roomNoTxt.Text);
            RoomTB rb = dbCon.RoomTBs.SingleOrDefault(x => x.roomNumber == roomNumber );
            if (rb != null)
            {
                rb.price = Convert.ToDouble(priceTxt.Text);
                rb.status = comboBox1.SelectedItem.ToString();
                dbCon.SubmitChanges();
                MessageBox.Show("Data Updated !!");
                this.roomTBTableAdapter.Fill(this.dBLinqDataSet3.RoomTB);
                roomNoTxt.Text = null;
                priceTxt.Text = null;
                comboBox1.Text = null;

            }
            else
                MessageBox.Show("RoomNumber Can't Update ","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            int roomNumber = Int32.Parse(roomNoTxt.Text);
            RoomTB rb = dbCon.RoomTBs.SingleOrDefault(x => x.roomNumber == roomNumber);
            if (rb != null)
            {
                dbCon.RoomTBs.DeleteOnSubmit(rb);
                dbCon.SubmitChanges();
                MessageBox.Show("Data deleted ", "DeleteMessage");
                this.roomTBTableAdapter.Fill(this.dBLinqDataSet3.RoomTB);
                roomNoTxt.Text = null;
                priceTxt.Text = null;
                comboBox1.Text = null;
            }
            else
                MessageBox.Show("Data not found !!","ErrorMessage",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)   // Search Button
        {

            DataClasses1DataContext dbCon = new DataClasses1DataContext();
           int roomNumber = Int32.Parse(searchTxt.Text);
            RoomTB rb = dbCon.RoomTBs.SingleOrDefault(x => x.roomNumber == roomNumber);
            if (rb != null)
            {
                sRoomNoTxt.Text = rb.roomNumber.ToString();
                sPriceTxt.Text = rb.price.ToString();
                sStatusTxt.Text = rb.status.ToString();
                sRoomNoTxt.ReadOnly = true;
                sPriceTxt.ReadOnly = true;
                sStatusTxt.ReadOnly = true;

                sRoomNoTxt.Visible = true;
                sPriceTxt.Visible = true;
                sStatusTxt.Visible = true;

                roomNoLabel.Visible = true;
                priceLabel.Visible = true;
                statusLable.Visible = true;
               


                
            }
            else
                MessageBox.Show("Data Not found");
        }

        private void searchTxt_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
