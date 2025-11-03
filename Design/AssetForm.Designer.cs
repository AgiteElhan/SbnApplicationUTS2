namespace SbnApplicationUTS.Design
{
    partial class AssetForm
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtDetailBuyer = new TextBox();
            txtSbnDetail = new TextBox();
            txtJumlah = new TextBox();
            txtTotal = new TextBox();
            dtpTanggal = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            cmbBuyer = new ComboBox();
            cmbSBN = new ComboBox();
            btnBack = new Button();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 580);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "Total Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 511);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Jumlah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 381);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 4;
            label5.Text = "Nama SBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 226);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 6;
            label7.Text = "Nama Buyer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(27, 153);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(148, 25);
            label9.TabIndex = 8;
            label9.Text = "Tanggal Transaksi";
            // 
            // txtDetailBuyer
            // 
            txtDetailBuyer.Location = new Point(327, 223);
            txtDetailBuyer.Margin = new Padding(4);
            txtDetailBuyer.Multiline = true;
            txtDetailBuyer.Name = "txtDetailBuyer";
            txtDetailBuyer.ReadOnly = true;
            txtDetailBuyer.Size = new Size(185, 112);
            txtDetailBuyer.TabIndex = 10;
            txtDetailBuyer.TextChanged += txtDetailBuyer_TextChanged;
            // 
            // txtSbnDetail
            // 
            txtSbnDetail.Location = new Point(327, 381);
            txtSbnDetail.Margin = new Padding(4);
            txtSbnDetail.Multiline = true;
            txtSbnDetail.Name = "txtSbnDetail";
            txtSbnDetail.ReadOnly = true;
            txtSbnDetail.Size = new Size(185, 101);
            txtSbnDetail.TabIndex = 12;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(200, 511);
            txtJumlah.Margin = new Padding(4);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(312, 31);
            txtJumlah.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(200, 580);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(312, 31);
            txtTotal.TabIndex = 16;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(200, 153);
            dtpTanggal.Margin = new Padding(4);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(312, 31);
            dtpTanggal.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(45, 45, 45);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(87, 637);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 34);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(45, 45, 45);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(200, 635);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 34);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(45, 45, 45);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(310, 637);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 34);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(421, 637);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 34);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(549, 153);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(514, 568);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbBuyer
            // 
            cmbBuyer.FormattingEnabled = true;
            cmbBuyer.Location = new Point(200, 223);
            cmbBuyer.Name = "cmbBuyer";
            cmbBuyer.Size = new Size(111, 33);
            cmbBuyer.TabIndex = 24;
            cmbBuyer.SelectedIndexChanged += cmbBuyer_SelectedIndexChanged;
            // 
            // cmbSBN
            // 
            cmbSBN.FormattingEnabled = true;
            cmbSBN.Location = new Point(200, 381);
            cmbSBN.Name = "cmbSBN";
            cmbSBN.Size = new Size(111, 33);
            cmbSBN.TabIndex = 25;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(45, 45, 45);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(85, 723);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 34);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(549, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 28;
            label1.Text = "Asset Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 108);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 27;
            label4.Text = "Asset Form";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(383, 39);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(316, 38);
            label8.TabIndex = 29;
            label8.Text = "🏦  SBN APPLICATION";
            // 
            // AssetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1078, 844);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(cmbSBN);
            Controls.Add(cmbBuyer);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpTanggal);
            Controls.Add(txtTotal);
            Controls.Add(txtJumlah);
            Controls.Add(txtSbnDetail);
            Controls.Add(txtDetailBuyer);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "AssetForm";
            Text = "AssetForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label9;
        private TextBox txtDetailBuyer;
        private TextBox txtSbnDetail;
        private TextBox txtJumlah;
        private TextBox txtTotal;
        private DateTimePicker dtpTanggal;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridView1;
        private ComboBox cmbBuyer;
        private ComboBox cmbSBN;
        private Button btnBack;
        private Label label1;
        private Label label4;
        private Label label8;
    }
}