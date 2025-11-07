using Microsoft.EntityFrameworkCore;
using SbnApplicationUTS2;
using SbnApplicationUTS2.Data;
using SbnApplicationUTS2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SbnApplicationUTS.Design
{
    public partial class BuyerForm : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedBuyerId = -1;
        public BuyerForm()
        {
            InitializeComponent();
            LoadData();
            this.Load += BuyerForm_Load;
        }

        internal void setVisible(bool v)
        {
            this.Visible = v;
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var data = db.Buyers.ToList();
            dgvBuyer.AutoGenerateColumns = true;
            dgvBuyer.DataSource = data;

            // --- Tambahkan pengaturan warna font hitam ---
            dgvBuyer.DefaultCellStyle.ForeColor = Color.Black; // Warna teks isi grid
            dgvBuyer.DefaultCellStyle.SelectionForeColor = Color.Black; // Saat dipilih
            dgvBuyer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Header kolom
            dgvBuyer.EnableHeadersVisualStyles = false; // Pastikan warna header diterapkan
        }
        private void ClearForm()
        {
            txtCode.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            selectedBuyerId = -1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            var buyer = new Buyer
            {
                Code = txtCode.Text,
                Nama = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text
            };

            db.Buyers.Add(buyer);
            db.SaveChanges();

            MessageBox.Show("Data berhasil ditambahkan!");
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBuyerId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diupdate terlebih dahulu!");
                return;
            }

            var buyer = db.Buyers.Find(selectedBuyerId);
            if (buyer != null)
            {
                buyer.Code = txtCode.Text;
                buyer.Nama = txtName.Text;
                buyer.Email = txtEmail.Text;
                buyer.PhoneNumber = txtPhone.Text;
                buyer.Address = txtAddress.Text;

                db.SaveChanges();
                MessageBox.Show("Data berhasil diupdate!");
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBuyerId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!");
                return;
            }

            var buyer = db.Buyers.Find(selectedBuyerId);
            if (buyer != null)
            {
                db.Buyers.Remove(buyer);
                db.SaveChanges();
                MessageBox.Show("Data berhasil dihapus!");
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvBuyer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvBuyer.Rows[e.RowIndex];
                selectedBuyerId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtName.Text = row.Cells["Nama"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm formHome = new HomeForm();
            formHome.setVisible(true);
        }
    }
}
