using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class CustomerDAO : StockContext, IDAO<CUSTOMER, CustomerDetailsDTO>
    {
        public bool Delete(CUSTOMER entity)
        {
            try
            {
                CUSTOMER customer = db.CUSTOMERs.First(x => x.ID == entity.ID);
                customer.isDeleted = true;
                customer.DeletedDate = DateTime.Today;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                CUSTOMER customer = db.CUSTOMERs.First(x => x.ID == ID);
                customer.isDeleted = false;
                customer.DeletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(CUSTOMER entity)
        {
            try
            {
                db.CUSTOMERs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            };
        }

        public List<CustomerDetailsDTO> Select()
        {
            try
            {
                List<CustomerDetailsDTO> customers = new List<CustomerDetailsDTO>();
                var list = db.CUSTOMERs.Where(x => x.isDeleted == false).ToList();
                foreach ( var item in list )
                {
                    CustomerDetailsDTO dto = new CustomerDetailsDTO();
                    dto.CustomerName = item.CustomerName;
                    dto.ID = item.ID;
                    customers.Add(dto);
                }
                return customers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<CustomerDetailsDTO> Select(bool isDeleted)
        {
            try
            {
                List<CustomerDetailsDTO> customers = new List<CustomerDetailsDTO>();
                var list = db.CUSTOMERs.Where(x => x.isDeleted == isDeleted).ToList();
                foreach (var item in list)
                {
                    CustomerDetailsDTO dto = new CustomerDetailsDTO();
                    dto.CustomerName = item.CustomerName;
                    dto.ID = item.ID;
                    customers.Add(dto);
                }
                return customers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(CUSTOMER entity)
        {
            try
            {
                CUSTOMER customer = db.CUSTOMERs.First(x => x.ID == entity.ID);
                customer.CustomerName = entity.CustomerName;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
