using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangDoChoiThuCung
{
    public class DsNguoiDung
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string repassword { get; set; }

        public DsNguoiDung()
        {

        }
        public DsNguoiDung(string name, string email, string password, string repassword)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.repassword = repassword;
        }
    }
}