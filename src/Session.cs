using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.BUS
{
    public static class Session
    {
        public static DTO.User CurrentUser { get; set; }

        public static bool IsAdmin =>
            CurrentUser != null &&
            CurrentUser.Role.Equals("Admin", System.StringComparison.OrdinalIgnoreCase);
    }
}
