﻿using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class ProductDAO : StockContext, IDAO<PRODUCT, ProductDetailsDTO>
    {
        public bool Delete(PRODUCT entity)
        {
            try
            {
                if (entity.ID != 0)
                {
                    PRODUCT product = db.PRODUCTs.First(x => x.ID == entity.ID);
                    product.isDeleted = true;
                    product.DeletedDate = DateTime.Today;
                    db.SaveChanges();
                }
                else if (entity.CategoryID != 0)
                {
                    List<PRODUCT> list = db.PRODUCTs.Where(x=>x.CategoryID==entity.CategoryID).ToList();
                    foreach (PRODUCT item in list)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                        List<SALE> sales = db.SALES.Where(x => x.ProductID == item.ID).ToList();
                        foreach (var item2 in sales)
                        {
                            item2.isDeleted = true;
                            item2.DeletedDate = DateTime.Today;
                        }
                    }
                    db.SaveChanges();
                }
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
                PRODUCT product = db.PRODUCTs.First(x => x.ID == ID);
                product.isDeleted = false;
                product.DeletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(PRODUCT entity)
        {
            try
            {
                db.PRODUCTs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ProductDetailsDTO> Select()
        {
            try
            {
                List<ProductDetailsDTO> product = new List<ProductDetailsDTO>();
                var list = (from p in db.PRODUCTs.Where(x => x.isDeleted == false)
                            join c in db.CATEGORies on p.CategoryID equals c.ID
                            select new
                            {
                                productName = p.ProductName,
                                categoryName = c.CategoryName,
                                stockAmount = p.StockAmount,
                                price = p.Price,
                                productID = p.ID,
                                categoryID = c.ID
                            }).OrderBy(x => x.productName).ToList();
                foreach (var item in list)
                {
                    ProductDetailsDTO dto = new ProductDetailsDTO();
                    dto.ProductName = item.productName;
                    dto.CategoryName = item.categoryName;
                    dto.StockAmount = item.stockAmount;
                    dto.Price = item.price;
                    dto.ProductID = item.productID;
                    dto.CategoryID = item.categoryID;
                    product.Add(dto);
                }
                return product;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ProductDetailsDTO> Select(bool isDeleted)
        {
            try
            {
                List<ProductDetailsDTO> product = new List<ProductDetailsDTO>();
                var list = (from p in db.PRODUCTs.Where(x => x.isDeleted == isDeleted)
                            join c in db.CATEGORies on p.CategoryID equals c.ID
                            select new
                            {
                                productName = p.ProductName,
                                categoryName = c.CategoryName,
                                stockAmount = p.StockAmount,
                                price = p.Price,
                                productID = p.ID,
                                categoryID = c.ID,
                                categoryisDeleted = c.isDeleted
                            }).OrderBy(x => x.productName).ToList();
                foreach (var item in list)
                {
                    ProductDetailsDTO dto = new ProductDetailsDTO();
                    dto.ProductName = item.productName;
                    dto.CategoryName = item.categoryName;
                    dto.StockAmount = item.stockAmount;
                    dto.Price = item.price;
                    dto.ProductID = item.productID;
                    dto.CategoryID = item.categoryID;
                    dto.isCategoryDeleted = item.categoryisDeleted;
                    product.Add(dto);
                }
                return product;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(PRODUCT entity)
        {
            try
            {
                PRODUCT product = db.PRODUCTs.First(x => x.ID == entity.ID);
                if (entity.CategoryID == 0)
                {
                    product.StockAmount = entity.StockAmount;
                }
                else
                {
                    product.ProductName = entity.ProductName;
                    product.Price = entity.Price;
                    product.CategoryID = entity.CategoryID;
                }
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
