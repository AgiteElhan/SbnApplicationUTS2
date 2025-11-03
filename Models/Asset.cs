using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS2.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public DateTime TanggalTransaksi { get; set; }

        // Relasi ke Buyer
        public int BuyerId { get; set; }     // Foreign key → mengacu ke Buyer.Id
        public Buyer Buyer { get; set; }     // Navigation property → akses detail Buyer

        // Relasi ke SBN
        public int SBNId { get; set; }
        public SBN SBN { get; set; }

        public int Jumlah { get; set; }
        public decimal TotalHarga { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModDate { get; set; }
    }
}
}
