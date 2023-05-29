using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDoChoiThuCung
{
    public partial class Dang_Ky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form.Get("tendn");
                string email = Request.Form.Get("email");
                string password = Request.Form.Get("matkhau");
                string repassword = Request.Form.Get("re-password");
                List<DsNguoiDung> users = (List<DsNguoiDung>)Application["nguoidung"];
                bool check = true;
                if (username != "" && email != "" && password != "" && repassword != "")
                {
                    foreach (DsNguoiDung user in users)
                    {
                        if (username == user.name)
                        {
                            err.Text = "Tài khoản đã được sử dụng";
                            check = false;
                        }
                    }

                    if (password != repassword)
                    {
                        err.Text = "Mật khẩu và xác nhận mật khẩu không giống nhau!";
                        return;
                    }

                    if (check)
                    {
                        err.Text = "Đăng ký thành công";
                        DsNguoiDung newUser = new DsNguoiDung(username, email, password, repassword);
                        users.Add(newUser);
                        Application["nguoidung"] = users;
                    }
                }
            }
        }
    }
}