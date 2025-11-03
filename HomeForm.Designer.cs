namespace SbnApplicationUTS2
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSBN = new Button();
            btnAsset = new Button();
            btnBuyer = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 394);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 28;
            label1.Text = "@2025KelompokSBN";
            // 
            // btnSBN
            // 
            btnSBN.BackColor = Color.FromArgb(45, 45, 45);
            btnSBN.FlatAppearance.BorderSize = 0;
            btnSBN.FlatStyle = FlatStyle.Flat;
            btnSBN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSBN.ForeColor = Color.White;
            btnSBN.Location = new Point(325, 201);
            btnSBN.Name = "btnSBN";
            btnSBN.Size = new Size(150, 50);
            btnSBN.TabIndex = 27;
            btnSBN.Text = "SBN";
            btnSBN.UseVisualStyleBackColor = false;
            btnSBN.Click += btnSBN_Click;
            // 
            // btnAsset
            // 
            btnAsset.BackColor = Color.FromArgb(45, 45, 45);
            btnAsset.FlatAppearance.BorderSize = 0;
            btnAsset.FlatStyle = FlatStyle.Flat;
            btnAsset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsset.ForeColor = Color.White;
            btnAsset.Location = new Point(557, 201);
            btnAsset.Name = "btnAsset";
            btnAsset.Size = new Size(150, 50);
            btnAsset.TabIndex = 26;
            btnAsset.Text = "Asset";
            btnAsset.UseVisualStyleBackColor = false;
            btnAsset.Click += btnAsset_Click;
            // 
            // btnBuyer
            // 
            btnBuyer.BackColor = Color.FromArgb(45, 45, 45);
            btnBuyer.FlatAppearance.BorderSize = 0;
            btnBuyer.FlatStyle = FlatStyle.Flat;
            btnBuyer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuyer.ForeColor = Color.White;
            btnBuyer.Location = new Point(94, 201);
            btnBuyer.Name = "btnBuyer";
            btnBuyer.Size = new Size(150, 50);
            btnBuyer.TabIndex = 25;
            btnBuyer.Text = "Buyer";
            btnBuyer.UseVisualStyleBackColor = false;
            btnBuyer.Click += btnBuyer_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(181, 32);
            label8.Name = "label8";
            label8.Size = new Size(451, 54);
            label8.TabIndex = 24;
            label8.Text = "🏦  SBN APPLICATION";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSBN);
            Controls.Add(btnAsset);
            Controls.Add(btnBuyer);
            Controls.Add(label8);
            Name = "HomeForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSBN;
        private Button btnAsset;
        private Button btnBuyer;
        private Label label8;
    }
}
