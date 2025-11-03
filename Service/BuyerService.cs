using SbnApplicationUTS2.Data;
using SbnApplicationUTS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS2.Service
{
    public class BuyerService
    {
        private readonly AppDbContext _db;
        public BuyerService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.Buyers.OrderBy(m => m.Nama)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.Id + " - " + m.Nama
                })
                .ToList<object>();
            return list;
        }

        public Buyer? FindById(int id)
        {
            return _db.Buyers.FirstOrDefault(x => x.Id == id);
        }

        public List<Buyer> SetGrid()
        {
            return
                _db.Buyers.OrderByDescending(m => m.ModDate).ToList<Buyer>();
        }

        public async void Update(Buyer buyer)
        {
            _db.Buyers.Update(buyer);
            await _db.SaveChangesAsync();
        }
    }
}
}
