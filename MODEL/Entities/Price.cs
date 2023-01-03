using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Price : BaseEntity
    {
        public decimal priceForMonth { get; set; }
        public decimal priceForThreeMonth { get; set; }
        public decimal priceForSixMonths { get; set; }
        public decimal priceForYear { get; set; }
    }
}
