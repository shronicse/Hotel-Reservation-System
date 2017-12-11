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
    public partial class Form6 : Form
    {
        static double balance;
        int cId;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)      // confitm button
        {
            try
            {
                DataClasses1DataContext dbCon = new DataClasses1DataContext();
                customer cr = new customer();
                cr.name = nameTxt.Text;
                cr.password = Convert.ToInt32(passwordTxt.Text);
                cr.phone = phoneTxt.Text;
                cr.Address = addressTxt.Text;
                cr.date = Convert.ToDateTime(dateTimePickerTxt.Text);
                cr.roomNumber = Convert.ToInt32(roomIdTxt.Text);
                RoomTB rm = dbCon.RoomTBs.SingleOrDefault(x => x.roomNumber == Convert.ToInt32(roomIdTxt.Text));
                if (rm != null)
                {
                    balance = Convert.ToDouble(rm.price);     // traking room price
                    if (MessageBox.Show("Are you want to confirm Room with price : " + balance + " ?", "BookingConfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbCon.customers.InsertOnSubmit(cr);
                        dbCon.SubmitChanges();

                        this.Hide();
                        Form10 f10 = new Form10();
                        f10.Show();

                        transection tn = new transection();  // transection entry 
                        tn.customerId = cr.customerId;
                        tn.balance = balance;
                        dbCon.transections.InsertOnSubmit(tn);
                        dbCon.SubmitChanges();

                        record rd = new record();        // record entry
                        rd.customerId = cr.customerId;
                        rd.roomId = Convert.ToInt32(cr.roomNumber);
                        rd.date = cr.date;
                        cId = cr.customerId;    // traking customerId
                        dbCon.records.InsertOnSubmit(rd);
                        dbCon.SubmitChanges();
                       // MessageBox.Show("Data added to record");


                       
                    }
                }
                else
                    MessageBox.Show("There is no room in this content");


               

            }
            catch(Exception ex)
            {
                MessageBox.Show("Data aren't insert correctly","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        public double retBalance()
        {
            return balance;
        }
        public int retId()
        {
            return cId;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button1_Click(object sender, EventArgs e)   // searchroom button
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext();
            var rcrd = from rcd in dbCon.records
                       where rcd.date == dateTimePicker1.Value//dateSearchTxt.Value.ToShortDateString()
                       select new { rcd.roomId };

            dataGridView1.DataSource = from rcd in dbCon.RoomTBs
                                       where !(rcrd.Any(x => x.roomId == rcd.roomNumber))
                                       select new { rcd.roomNumber, rcd.price };
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roomIdTxt.Text = row.Cells[0].Value.ToString();

            }
        }
    }
}
