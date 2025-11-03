namespace SbnApplicationUTS.Design
{
    partial class BuyerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnAddBuyer = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvBuyer = new DataGridView();
            btnBack = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBuyer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 67);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 0;
            label1.Text = "Buyer Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 104);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Buyer Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 142);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Buyer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 180);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Email ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 221);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 268);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(166, 99);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(252, 27);
            txtCode.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(166, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(166, 221);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(252, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(166, 263);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(252, 27);
            txtAddress.TabIndex = 10;
            // 
            // btnAddBuyer
            // 
            btnAddBuyer.BackColor = Color.FromArgb(45, 45, 45);
            btnAddBuyer.FlatAppearance.BorderSize = 0;
            btnAddBuyer.FlatStyle = FlatStyle.Flat;
            btnAddBuyer.Location = new Point(39, 317);
            btnAddBuyer.Name = "btnAddBuyer";
            btnAddBuyer.Size = new Size(94, 29);
            btnAddBuyer.TabIndex = 11;
            btnAddBuyer.Text = "Add";
            btnAddBuyer.UseVisualStyleBackColor = false;
            btnAddBuyer.Click += btnAddBuyer_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(45, 45, 45);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(139, 317);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(45, 45, 45);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(239, 317);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(339, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBuyer
            // 
            dgvBuyer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuyer.Location = new Point(442, 104);
            dgvBuyer.Name = "dgvBuyer";
            dgvBuyer.RowHeadersWidth = 51;
            dgvBuyer.Size = new Size(410, 257);
            dgvBuyer.TabIndex = 15;
            dgvBuyer.CellContentClick += dgvBuyer_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(45, 45, 45);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(39, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(442, 67);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 17;
            label7.Text = "Buyer Data";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(287, 22);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(272, 32);
            label8.TabIndex = 18;
            label8.Text = "🏦  SBN APPLICATION";
            // 
            // BuyerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(862, 435);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(dgvBuyer);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddBuyer);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "BuyerForm";
            Text = "BuyerForm";
            Load += BuyerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuyer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnAddBuyer;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvBuyer;
        private Button btnBack;
        private Label label7;
        private Label label8;
    }
}