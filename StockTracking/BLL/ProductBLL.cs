using StockTracking.DAL;
using StockTracking.DAL.DAO;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.BLL
{
    public class ProductBLL : IBLL<ProductDetailsDTO, ProductDTO>
    {
        CategoryDAO categorydao = new CategoryDAO();
        ProductDAO dao = new ProductDAO();
        SalesDAO salesdao = new SalesDAO();
        public bool Delete(ProductDetailsDTO entity)
        {
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            dao.Delete(product);
            SALE sales = new SALE();
            sales.ProductID = entity.ProductID;
            salesdao.Delete(sales);
            return true;
        }

        public bool GetBack(ProductDetailsDTO entity)
        {
            return dao.GetBack(entity.ProductID);
        }

        public bool Insert(ProductDetailsDTO entity)
        {
            PRODUCT product = new PRODUCT();
            product.ProductName = entity.ProductName;
            product.CategoryID = entity.CategoryID;
            product.Price = entity.Price;
            return dao.Insert(product);
        }

        public ProductDTO Select()
        {
            ProductDTO dto = new ProductDTO();
            dto.categories = categorydao.Select();
            dto.products = dao.Select();
            return dto;
        }

        public bool Update(ProductDetailsDTO entity)
        {
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            product.CategoryID = entity.CategoryID;
            product.Price = entity.Price;
            product.ProductName = entity.ProductName;
            product.StockAmount = entity.StockAmount;
            return dao.Update(product);
        }
    }
}
