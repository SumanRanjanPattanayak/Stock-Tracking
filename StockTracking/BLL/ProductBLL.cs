﻿using StockTracking.DAL;
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
        public bool Delete(ProductDetailsDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(ProductDetailsDTO entity)
        {
            throw new NotImplementedException();
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
