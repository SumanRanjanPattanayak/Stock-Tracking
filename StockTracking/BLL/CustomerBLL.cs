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
    public class CustomerBLL : IBLL<CustomerDetailsDTO, CustomerDTO>
    {
        CustomerDAO dao = new CustomerDAO();
        SalesDAO salesdao = new SalesDAO();
        public bool Delete(CustomerDetailsDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.ID = entity.ID;
            dao.Delete(customer);
            SALE sales = new SALE();
            sales.CustomerID = entity.ID;
            salesdao.Delete(sales);
            return true;
        }

        public bool GetBack(CustomerDetailsDTO entity)
        {
            return dao.GetBack(entity.ID);
        }

        public bool Insert(CustomerDetailsDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.CustomerName = entity.CustomerName;
            return dao.Insert(customer);
        }

        public CustomerDTO Select()
        {
            CustomerDTO dto = new CustomerDTO();
            dto.customers = dao.Select();
            return dto;
        }

        public bool Update(CustomerDetailsDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.ID = entity.ID;
            customer.CustomerName = entity.CustomerName;
            return dao.Update(customer);
        }
    }
}
