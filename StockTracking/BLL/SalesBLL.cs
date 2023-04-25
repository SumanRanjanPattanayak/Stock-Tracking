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
    public class SalesBLL : IBLL<SalesDetailsDTO, SalesDTO>
    {
        SalesDAO dao = new SalesDAO();
        ProductDAO productdao = new ProductDAO();
        CategoryDAO categorydao = new CategoryDAO();
        CustomerDAO customerdao = new CustomerDAO();
        public bool Delete(SalesDetailsDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(SalesDetailsDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SalesDetailsDTO entity)
        {
            SALE sales = new SALE();
            sales.CategoryID = entity.CategoryID;
            sales.ProductID = entity.ProductID;
            sales.CustomerID = entity.CustomerID;
            sales.ProductSalesPrice = entity.Price;
            sales.ProductSalesAmount = entity.SalesAmount;
            sales.SalesDate = entity.SalesDate;
            dao.Insert(sales);
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp;
            productdao.Update(product);
            return true;
        }

        public SalesDTO Select()
        {
            SalesDTO dto = new SalesDTO();
            dto.Products = productdao.Select();
            dto.Customers = customerdao.Select();
            dto.Categories = categorydao.Select();
            dto.Sales = dao.Select();
            return dto;
        }

        public bool Update(SalesDetailsDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
