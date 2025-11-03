using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS2.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModDate { get; set; }

    }
}
