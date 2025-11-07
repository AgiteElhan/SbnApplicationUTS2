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

namespace SbnApplicationUTS2.Design
{
    public partial class SbnForm : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedSbnId = -1;

        public SbnForm()
        {
            InitializeComponent();
            LoadData();
            this.Load += SbnForm_Load;
            dataGridSBN.CellClick += dataGridSBN_CellClick; // <--- tambahkan ini

        }

        internal void setVisible(bool v)
        {
            this.Visible = v;
        }

        private void SbnForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = db.SBNs.ToList();
            dataGridSBN.AutoGenerateColumns = true;
            dataGridSBN.DataSource = data;

            // Warna font hitam di DataGridView
            dataGridSBN.DefaultCellStyle.ForeColor = Color.Black;
            dataGridSBN.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridSBN.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridSBN.EnableHeadersVisualStyles = false;
        }

        private void ClearForm()
        {
            txtCode.Clear();
            txtNama.Clear();
            txtType.Clear();
            txtPrice.Clear();
            selectedSbnId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validasi harga agar hanya bisa integer
            if (!int.TryParse(txtPrice.Text, out int unitPrice))
            {
                MessageBox.Show("Unit Price harus berupa angka bulat (integer).");
                return;
            }

            var sbn = new SBN
            {
                Kode_Sbn = txtCode.Text,
                Nama_SBN = txtNama.Text,
                Jenis = txtType.Text,
                Harga = unitPrice
            };

            db.SBNs.Add(sbn);
            db.SaveChanges();

            MessageBox.Show("Data berhasil ditambahkan!");
            LoadData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSbnId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diupdate terlebih dahulu!");
                return;
            }

            if (!int.TryParse(txtPrice.Text, out int unitPrice))
            {
                MessageBox.Show("Unit Price harus berupa angka bulat (integer).");
                return;
            }

            var sbn = db.SBNs.Find(selectedSbnId);
            if (sbn != null)
            {
                sbn.Kode_Sbn = txtCode.Text;
                sbn.Nama_SBN = txtNama.Text;
                sbn.Jenis = txtType.Text;
                sbn.Harga = unitPrice;

                db.SaveChanges();
                MessageBox.Show("Data berhasil diupdate!");
                LoadData();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSbnId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!");
                return;
            }

            var sbn = db.SBNs.Find(selectedSbnId);
            if (sbn != null)
            {
                db.SBNs.Remove(sbn);
                db.SaveChanges();
                MessageBox.Show("Data berhasil dihapus!");
                LoadData();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridSBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridSBN.Rows[e.RowIndex];

                selectedSbnId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCode.Text = row.Cells["Kode_Sbn"].Value?.ToString();
                txtNama.Text = row.Cells["Nama_SBN"].Value?.ToString();
                txtType.Text = row.Cells["Jenis"].Value?.ToString();
                txtPrice.Text = row.Cells["Harga"].Value?.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm formHome = new HomeForm();
            formHome.setVisible(true);
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            HomeForm formHome = new HomeForm();
            formHome.setVisible(false);
        }
    }
}
