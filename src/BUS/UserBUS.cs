using Kiemtragiuaki.DAL;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.BUS
{
    internal class UserBUS
    {

        // Khởi tạo đối tượng DAL để gọi các hàm truy vấn database
        private UserDAL _userDAL = new UserDAL();

        /// <summary>
        /// Xử lý logic đăng nhập
        /// </summary>
        /// <param name="username">Tên đăng nhập từ TextBox</param>
        /// <param name="password">Mật khẩu từ TextBox</param>
        /// <returns>Trả về đối tượng User nếu đúng, null nếu sai</returns>
        public User Login(string username, string password)
        {
            // 1. Kiểm tra dữ liệu đầu vào cơ bản (Validation)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Bạn có thể quăng lỗi hoặc xử lý tùy ý ở đây
                return null;
            }

            // 2. Gọi xuống lớp DAL để kiểm tra trong Database
            // Nếu bạn có làm hàm mã hóa mật khẩu (MD5/SHA256), hãy thực hiện ở đây trước khi gửi xuống DAL
            User user = _userDAL.Login(username, password);

            // 3. Trả kết quả về cho GUI
            return user;
        }

        /// <summary>
        /// Kiểm tra xem User có quyền Admin hay không (Dùng để phân quyền nhanh trên GUI)
        /// </summary>
        public bool IsAdmin(User user)
        {
            if (user == null) return false;
            return user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }
        public bool RegisterUser(string username, string password, string fullname)
        {
            // Ràng buộc điều kiện (Validation)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullname))
                return false;

            // Đẩy xuống DAL
            return _userDAL.RegisterUser(username, password, fullname);
        }
        public List<User> GetAllUsers()
        {
            return _userDAL.GetAllUsers();
        }

        public bool UpdateUserRole(string userID, string newRole)
        {
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(newRole))
                throw new Exception("Thông tin không hợp lệ.");
            return _userDAL.UpdateUserRole(userID, newRole);
        }

        public bool DeleteUser(string userID, string currentUserID)
        {
            if (userID == currentUserID)
                throw new Exception("Không thể xóa tài khoản đang đăng nhập!");
            return _userDAL.DeleteUser(userID);
        }
    }
}
