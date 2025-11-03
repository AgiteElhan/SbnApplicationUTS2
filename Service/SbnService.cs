using SbnApplicationUTS2.Data;
using SbnApplicationUTS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS2.Service
{
    public class SbnService
    {
        private readonly AppDbContext _db;
        public SbnService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.SBNs.OrderBy(m => m.Nama_SBN)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.Id + " - " + m.Nama_SBN
                })
                .ToList<object>();
            return list;
        }

        public SBN? FindById(int id)
        {
            return _db.SBNs.FirstOrDefault(x => x.Id == id);
        }

        public List<SBN> SetGrid()
        {
            return
                _db.SBNs.OrderByDescending(m => m.ModDate).ToList<SBN>();
        }

        public async void Update(SBN SBN)
        {
            _db.SBNs.Update(SBN);
            await _db.SaveChangesAsync();
        }
    }
}

