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
            txt_kode_buyer = new TextBox();
            txt_kode_sbn = new TextBox();
            txt_jumlah = new TextBox();
            txt_total_harga = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btn_tambah = new Button();
            btn_update = new Button();
            btn_hapus = new Button();
            btn_clear = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            // txt_kode_buyer
            // 
            txt_kode_buyer.Location = new Point(327, 223);
            txt_kode_buyer.Margin = new Padding(4, 4, 4, 4);
            txt_kode_buyer.Multiline = true;
            txt_kode_buyer.Name = "txt_kode_buyer";
            txt_kode_buyer.ReadOnly = true;
            txt_kode_buyer.Size = new Size(185, 112);
            txt_kode_buyer.TabIndex = 10;
            // 
            // txt_kode_sbn
            // 
            txt_kode_sbn.Location = new Point(327, 381);
            txt_kode_sbn.Margin = new Padding(4, 4, 4, 4);
            txt_kode_sbn.Multiline = true;
            txt_kode_sbn.Name = "txt_kode_sbn";
            txt_kode_sbn.ReadOnly = true;
            txt_kode_sbn.Size = new Size(185, 101);
            txt_kode_sbn.TabIndex = 12;
            // 
            // txt_jumlah
            // 
            txt_jumlah.Location = new Point(200, 511);
            txt_jumlah.Margin = new Padding(4, 4, 4, 4);
            txt_jumlah.Name = "txt_jumlah";
            txt_jumlah.Size = new Size(312, 31);
            txt_jumlah.TabIndex = 15;
            // 
            // txt_total_harga
            // 
            txt_total_harga.Location = new Point(200, 580);
            txt_total_harga.Margin = new Padding(4, 4, 4, 4);
            txt_total_harga.Name = "txt_total_harga";
            txt_total_harga.ReadOnly = true;
            txt_total_harga.Size = new Size(312, 31);
            txt_total_harga.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(200, 153);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = Color.FromArgb(45, 45, 45);
            btn_tambah.FlatAppearance.BorderSize = 0;
            btn_tambah.FlatStyle = FlatStyle.Flat;
            btn_tambah.ForeColor = Color.White;
            btn_tambah.Location = new Point(87, 637);
            btn_tambah.Margin = new Padding(4, 4, 4, 4);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(90, 34);
            btn_tambah.TabIndex = 18;
            btn_tambah.Text = "Add";
            btn_tambah.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(45, 45, 45);
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(200, 635);
            btn_update.Margin = new Padding(4, 4, 4, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(90, 34);
            btn_update.TabIndex = 19;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_hapus
            // 
            btn_hapus.BackColor = Color.FromArgb(45, 45, 45);
            btn_hapus.FlatAppearance.BorderSize = 0;
            btn_hapus.FlatStyle = FlatStyle.Flat;
            btn_hapus.ForeColor = Color.White;
            btn_hapus.Location = new Point(310, 637);
            btn_hapus.Margin = new Padding(4, 4, 4, 4);
            btn_hapus.Name = "btn_hapus";
            btn_hapus.Size = new Size(90, 34);
            btn_hapus.TabIndex = 20;
            btn_hapus.Text = "Delete";
            btn_hapus.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(45, 45, 45);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(421, 637);
            btn_clear.Margin = new Padding(4, 4, 4, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(90, 34);
            btn_clear.TabIndex = 21;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(549, 153);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(514, 568);
            dataGridView1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 33);
            comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(200, 381);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 33);
            comboBox2.TabIndex = 25;
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
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_clear);
            Controls.Add(btn_hapus);
            Controls.Add(btn_update);
            Controls.Add(btn_tambah);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_total_harga);
            Controls.Add(txt_jumlah);
            Controls.Add(txt_kode_sbn);
            Controls.Add(txt_kode_buyer);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 4, 4, 4);
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
        private TextBox txt_kode_buyer;
        private TextBox txt_kode_sbn;
        private TextBox txt_jumlah;
        private TextBox txt_total_harga;
        private DateTimePicker dateTimePicker1;
        private Button btn_tambah;
        private Button btn_update;
        private Button btn_hapus;
        private Button btn_clear;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnBack;
        private Label label1;
        private Label label4;
        private Label label8;
    }
}