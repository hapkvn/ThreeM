using Kiemtragiuaki.DAL;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;

namespace Kiemtragiuaki.BUS
{
    public class CategoryBUS
    {
        private CategoryDAL dal = new CategoryDAL();

        public List<CategoryDTO> LayTatCaTheLoai()
        {
            return dal.GetAllCategories();
        }

        public bool ThemTheLoai(CategoryDTO c)
        {
            if (string.IsNullOrWhiteSpace(c.CategoryName))
                throw new Exception("Tên thể loại không được để trống.");
            if (string.IsNullOrWhiteSpace(c.CategoryID))
                c.CategoryID = "CAT_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            return dal.AddCategory(c);
        }

        public bool SuaTheLoai(CategoryDTO c)
        {
            if (string.IsNullOrWhiteSpace(c.CategoryName))
                throw new Exception("Tên thể loại không được để trống.");
            return dal.UpdateCategory(c);
        }

        public bool XoaTheLoai(string categoryID)
        {
            if (string.IsNullOrWhiteSpace(categoryID))
                throw new Exception("Chưa chọn thể loại cần xóa.");
            return dal.DeleteCategory(categoryID);
        }
    }
}