namespace WorkLinq
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNoTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLinqDataSet3 = new WorkLinq.DBLinqDataSet3();
            this.dBLinqDataSet2 = new WorkLinq.DBLinqDataSet2();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new WorkLinq.DBLinqDataSet2TableAdapters.roomTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.roomTBTableAdapter = new WorkLinq.DBLinqDataSet3TableAdapters.RoomTBTableAdapter();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusLable = new System.Windows.Forms.Label();
            this.sRoomNoTxt = new System.Windows.Forms.TextBox();
            this.sPriceTxt = new System.Windows.Forms.TextBox();
            this.sStatusTxt = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLinqDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLinqDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoomNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // roomNoTxt
            // 
            this.roomNoTxt.Location = new System.Drawing.Point(163, 55);
            this.roomNoTxt.Name = "roomNoTxt";
            this.roomNoTxt.Size = new System.Drawing.Size(121, 20);
            this.roomNoTxt.TabIndex = 3;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(163, 94);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(121, 20);
            this.priceTxt.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(66, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(172, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(430, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // roomTBBindingSource
            // 
            this.roomTBBindingSource.DataMember = "RoomTB";
            this.roomTBBindingSource.DataSource = this.dBLinqDataSet3;
            // 
            // dBLinqDataSet3
            // 
            this.dBLinqDataSet3.DataSetName = "DBLinqDataSet3";
            this.dBLinqDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBLinqDataSet2
            // 
            this.dBLinqDataSet2.DataSetName = "DBLinqDataSet2";
            this.dBLinqDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.dBLinqDataSet2;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "RoomNumber";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(527, 200);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 20);
            this.searchTxt.TabIndex = 13;
            this.searchTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomTBTableAdapter
            // 
            this.roomTBTableAdapter.ClearBeforeFill = true;
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Location = new System.Drawing.Point(476, 261);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(72, 13);
            this.roomNoLabel.TabIndex = 15;
            this.roomNoLabel.Text = "RoomNumber";
            this.roomNoLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 16;
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.Location = new System.Drawing.Point(479, 350);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(37, 13);
            this.statusLable.TabIndex = 17;
            this.statusLable.Text = "Status";
            this.statusLable.Visible = false;
            // 
            // sRoomNoTxt
            // 
            this.sRoomNoTxt.Location = new System.Drawing.Point(568, 258);
            this.sRoomNoTxt.Name = "sRoomNoTxt";
            this.sRoomNoTxt.Size = new System.Drawing.Size(100, 20);
            this.sRoomNoTxt.TabIndex = 18;
            this.sRoomNoTxt.Visible = false;
            // 
            // sPriceTxt
            // 
            this.sPriceTxt.Location = new System.Drawing.Point(568, 301);
            this.sPriceTxt.Name = "sPriceTxt";
            this.sPriceTxt.Size = new System.Drawing.Size(100, 20);
            this.sPriceTxt.TabIndex = 19;
            this.sPriceTxt.Visible = false;
            // 
            // sStatusTxt
            // 
            this.sStatusTxt.Location = new System.Drawing.Point(568, 342);
            this.sStatusTxt.Name = "sStatusTxt";
            this.sStatusTxt.Size = new System.Drawing.Size(100, 20);
            this.sStatusTxt.TabIndex = 20;
            this.sStatusTxt.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(476, 309);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 21;
            this.priceLabel.Text = "Price";
            this.priceLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(408, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 157);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SearchResult";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Booked",
            "Avilable"});
            this.comboBox1.Location = new System.Drawing.Point(163, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 423);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.sStatusTxt);
            this.Controls.Add(this.sPriceTxt);
            this.Controls.Add(this.sRoomNoTxt);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.roomNoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLinqDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLinqDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomNoTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBLinqDataSet2 dBLinqDataSet2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private DBLinqDataSet2TableAdapters.roomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button button1;
        private DBLinqDataSet3 dBLinqDataSet3;
        private System.Windows.Forms.BindingSource roomTBBindingSource;
        private DBLinqDataSet3TableAdapters.RoomTBTableAdapter roomTBTableAdapter;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statusLable;
        private System.Windows.Forms.TextBox sRoomNoTxt;
        private System.Windows.Forms.TextBox sPriceTxt;
        private System.Windows.Forms.TextBox sStatusTxt;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}