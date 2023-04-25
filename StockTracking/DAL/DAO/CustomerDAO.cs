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
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
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
                var list = db.CUSTOMERs;
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
