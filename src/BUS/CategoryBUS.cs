using Kiemtragiuaki.DAL;
using Kiemtragiuaki.DTO;
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
    }
}