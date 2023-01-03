using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArenaGym.DTOS
{
    public class PriceDTO
    {
        public decimal priceForMonth { get; set; }
        public decimal priceForThreeMonth { get; set; }
        public decimal priceForSixMonths { get; set; }
        public decimal priceForYear { get; set; }
    }
}
