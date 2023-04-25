﻿using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class SalesDAO : StockContext, IDAO<SALE, SalesDetailsDTO>
    {
        public bool Delete(SALE entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SALE entity)
        {
            try
            {
                db.SALES.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SalesDetailsDTO> Select()
        {
            try
            {
                List<SalesDetailsDTO> sales = new List<SalesDetailsDTO>();
                var list = (from s in db.SALES
                            join p in db.PRODUCTs on s.ProductID equals p.ID
                            join c in db.CUSTOMERs on s.CustomerID equals c.ID
                            join category in db.CATEGORies on s.CategoryID equals category.ID
                            select new
                            {
                                productname = p.ProductName,
                                customername = c.CustomerName,
                                categoryname = category.CategoryName,
                                productID = s.ProductID,
                                customerID = s.CustomerID,
                                salesID = s.ID,
                                categoryID = s.CategoryID,
                                salesprice = s.ProductSalesPrice,
                                salesamount = s.ProductSalesAmount,
                                salesdate = s.SalesDate
                            }).OrderBy(x => x.salesdate).ToList();
                foreach (var item in list)
                {
                    SalesDetailsDTO dto = new SalesDetailsDTO();
                    dto.ProductName = item.productname;
                    dto.CustomerName = item.customername;
                    dto.CategoryName = item.categoryname;
                    dto.ProductID = item.productID;
                    dto.CustomerID = item.customerID;
                    dto.CategoryID = item.categoryID;
                    dto.SalesID = item.salesID;
                    dto.Price = item.salesprice;
                    dto.SalesAmount = item.salesamount;
                    dto.SalesDate = item.salesdate;
                    sales.Add(dto);
                }
                return sales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(SALE entity)
        {
            throw new NotImplementedException();
        }
    }
}
