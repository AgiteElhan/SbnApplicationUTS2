using Microsoft.EntityFrameworkCore;
using SbnApplicationUTS2.Data;
using SbnApplicationUTS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS2.Service
{
    public class AssetService
    {
        private readonly AppDbContext _db;

        public AssetService(AppDbContext db)
        {
            _db = db;
        }

        // 🔹 Menampilkan daftar Asset ke grid (terbaru di atas)
        public List<Asset> SetGrid()
        {
            return _db.Assets
                .Include(t => t.Buyer)  // ambil data Buyer
                .Include(t => t.SBN)    // ambil data SBN
                .OrderByDescending(t => t.ModDate)
                .ToList();
        }

        // 🔹 Menambahkan Asset baru
        public async Task AddAsync(Asset Asset)
        {
            Asset.CreatedAt = DateTime.Now;
            Asset.ModDate = DateTime.Now;

            _db.Assets.Add(Asset);
            await _db.SaveChangesAsync();
        }

        // 🔹 Mengupdate Asset yang sudah ada
        public async Task UpdateAsync(Asset Asset)
        {
            Asset.ModDate = DateTime.Now;
            _db.Assets.Update(Asset);
            await _db.SaveChangesAsync();
        }

        // 🔹 Menghapus Asset
        public async Task DeleteAsync(int id)
        {
            var data = _db.Assets.FirstOrDefault(t => t.Id == id);
            if (data != null)
            {
                _db.Assets.Remove(data);
                await _db.SaveChangesAsync();
            }
        }

        // 🔹 Mencari Asset berdasarkan ID
        public Asset? FindById(int id)
        {
            return _db.Assets
                .Include(t => t.Buyer)
                .Include(t => t.SBN)
                .FirstOrDefault(t => t.Id == id);
        }
    }
}
