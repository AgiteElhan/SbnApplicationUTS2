namespace SbnApplicationUTS2.Design
{
    partial class SbnForm
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
            label7 = new Label();
            dataGridSBN = new DataGridView();
            btnBack = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            txtType = new TextBox();
            txtNama = new TextBox();
            txtCode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridSBN).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(522, 85);
            label7.Name = "label7";
            label7.Size = new Size(97, 28);
            label7.TabIndex = 33;
            label7.Text = "SBN Data";
            // 
            // dataGridSBN
            // 
            dataGridSBN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSBN.Location = new Point(522, 138);
            dataGridSBN.Name = "dataGridSBN";
            dataGridSBN.RowHeadersWidth = 62;
            dataGridSBN.Size = new Size(546, 352);
            dataGridSBN.TabIndex = 32;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(45, 45, 45);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(52, 486);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 34);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(386, 396);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 34);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(45, 45, 45);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(273, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 34);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(45, 45, 45);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(161, 396);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 34);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(45, 45, 45);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(52, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 34);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(192, 323);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(284, 31);
            txtPrice.TabIndex = 26;
            // 
            // txtType
            // 
            txtType.Location = new Point(192, 261);
            txtType.Name = "txtType";
            txtType.Size = new Size(284, 31);
            txtType.TabIndex = 25;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(192, 199);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(284, 31);
            txtNama.TabIndex = 24;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(192, 135);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(284, 31);
            txtCode.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 326);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 22;
            label6.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 264);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 21;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 202);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 20;
            label4.Text = "SBN Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 138);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 19;
            label3.Text = "SBN Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 85);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 18;
            label2.Text = "SBN Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(374, 32);
            label1.Name = "label1";
            label1.Size = new Size(316, 38);
            label1.TabIndex = 17;
            label1.Text = "🏦  SBN APPLICATION";
            // 
            // SbnForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1078, 544);
            Controls.Add(label7);
            Controls.Add(dataGridSBN);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtType);
            Controls.Add(txtNama);
            Controls.Add(txtCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SbnForm";
            Text = "SbnForm";
            ((System.ComponentModel.ISupportInitialize)dataGridSBN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView dataGridSBN;
        private Button btnBack;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPrice;
        private TextBox txtType;
        private TextBox txtNama;
        private TextBox txtCode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}