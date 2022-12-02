using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kişisel_Veri_Kayit_Uygulamasi
{
    public class Address
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Country Country { get; set; }

        public override string ToString()
        {
            return $"{Street} - {PostalCode} - {City}";
        }
    }
}
