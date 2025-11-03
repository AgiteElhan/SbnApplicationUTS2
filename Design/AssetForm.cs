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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SbnApplicationUTS.Design
{
    public partial class AssetForm : Form
    {
        private readonly AppDbContext _context;

        public AssetForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadComboBoxes();
            LoadData();
        }
        internal void setVisible(bool v)
        {
            this.Visible = v;
        }
        private void LoadComboBoxes()
        {
            cmbBuyer.DataSource = _context.Buyers.ToList();
            cmbBuyer.DisplayMember = "Nama";
            cmbBuyer.ValueMember = "Id";

            cmbSBN.DataSource = _context.SBNs.ToList();
            cmbSBN.DisplayMember = "NamaSBN";
            cmbSBN.ValueMember = "Id";
        }
        private void ClearForm()
        {
            cmbBuyer.SelectedIndex = -1;
            cmbSBN.SelectedIndex = -1;
            txtJumlah.Text = string.Empty;
            txtTotal.Text = string.Empty;
            dtpTanggal.Value = DateTime.Now;
        }
        private void LoadData()
        {
            var data = _context.Assets
                .Select(a => new
                {
                    a.Id,
                    a.TanggalTransaksi,
                    Buyer = a.Buyer.Nama,
                    SBN = a.SBN.Nama_SBN,
                    a.Jumlah,
                    a.TotalHarga
                })
                .ToList();

            dataGridView1.DataSource = data;
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBuyer.SelectedValue == null || cmbSBN.SelectedValue == null)
            {
                MessageBox.Show("Pilih Buyer dan SBN terlebih dahulu!");
                return;
            }

            var asset = new Asset
            {
                TanggalTransaksi = dtpTanggal.Value,
                BuyerId = (int)cmbBuyer.SelectedValue,
                SBNId = (int)cmbSBN.SelectedValue,
                Jumlah = int.Parse(txtJumlah.Text),
                TotalHarga = decimal.Parse(txtTotal.Text)
            };

            _context.Assets.Add(asset);
            _context.SaveChanges();

            LoadData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diupdate dari tabel!");
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var asset = _context.Assets.Find(id);
            if (asset == null) return;

            asset.TanggalTransaksi = dtpTanggal.Value;
            asset.BuyerId = (int)cmbBuyer.SelectedValue;
            asset.SBNId = (int)cmbSBN.SelectedValue;
            asset.Jumlah = int.Parse(txtJumlah.Text);
            asset.TotalHarga = decimal.Parse(txtTotal.Text);

            _context.SaveChanges();
            LoadData();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel!");
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var asset = _context.Assets.Find(id);
            if (asset == null) return;

            var confirm = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?",
                                          "Konfirmasi",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _context.Assets.Remove(asset);
                _context.SaveChanges();
                LoadData();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dtpTanggal.Value = (DateTime)row.Cells["TanggalTransaksi"].Value;
                cmbBuyer.Text = row.Cells["Buyer"].Value.ToString();
                cmbSBN.Text = row.Cells["SBN"].Value.ToString();
                txtJumlah.Text = row.Cells["Jumlah"].Value.ToString();
                txtTotal.Text = row.Cells["TotalHarga"].Value.ToString();
            }
        }

        private void txtDetailBuyer_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuyer.SelectedValue is int buyerId)
            {
                using (var db = new AppDbContext())
                {
                    var buyer = db.Buyers.FirstOrDefault(b => b.Id == buyerId);
                    if (buyer != null)
                    {
                        txtDetailBuyer.Text =
                            $"Nama: {buyer.Nama}\r\n" +
                            $"Email: {buyer.Email}\r\n" +
                            $"No HP: {buyer.PhoneNumber}\r\n" +
                            $"Alamat: {buyer.Address}";
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm formHome = new HomeForm();
            formHome.setVisible(true);
        }
    }
}

