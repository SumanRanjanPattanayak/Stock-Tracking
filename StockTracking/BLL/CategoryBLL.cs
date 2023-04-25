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
    public class CategoryBLL : IBLL<CategoryDetailsDTO, CategoryDTO>
    {
        CategoryDAO dao = new CategoryDAO();
        public bool Delete(CategoryDetailsDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(CategoryDetailsDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CategoryDetailsDTO entity)
        {
            CATEGORY category = new CATEGORY();
            category.CategoryName = entity.CategoryName;
            return dao.Insert(category);
        }

        public CategoryDTO Select()
        {
            CategoryDTO dto = new CategoryDTO();
            dto.categories = dao.Select();
            return dto;
        }

        public bool Update(CategoryDetailsDTO entity)
        {
            CATEGORY category = new CATEGORY();
            category.CategoryName = entity.CategoryName;
            category.ID = entity.ID;
            return dao.Update(category);
        }
    }
}
