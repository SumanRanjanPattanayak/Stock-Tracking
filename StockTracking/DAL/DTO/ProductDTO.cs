using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DTO
{
    public class ProductDTO
    {
        public List<ProductDetailsDTO> products { get; set; }
        public List<CategoryDetailsDTO> categories { get; set; }
    }
}
