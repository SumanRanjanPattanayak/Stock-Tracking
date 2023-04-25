using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DTO
{
    public class SalesDTO
    {
        public List<SalesDetailsDTO> Sales { get; set; }
        public List<CustomerDetailsDTO> Customers { get; set; }
        public List<ProductDetailsDTO> Products { get; set; }
        public List<CategoryDetailsDTO> Categories { get; set; }
    }
}
